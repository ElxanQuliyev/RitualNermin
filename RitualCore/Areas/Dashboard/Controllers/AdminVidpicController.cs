using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RitualCore.Areas.Dashboard.ViewModels;
using RitualCore.Data;
using RitualCore.Models;

namespace RitualCore.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class AdminVidpicController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IWebHostEnvironment _webHost;
        public AdminVidpicController(ApplicationDbContext context, IWebHostEnvironment webHost)
        {
            _context = context;
            _webHost = webHost;
        }

        // GET: Dashboard/AdminVidpic
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Viseoapics.Include(v => v.Category).Include(x=>x.Picture);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Dashboard/AdminVidpic/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viseoapic = await _context.Viseoapics
                .Include(v => v.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (viseoapic == null)
            {
                return NotFound();
            }

            return View(viseoapic);
        }

        // GET: Dashboard/AdminVidpic/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name");
            return View();
        }

        // POST: Dashboard/AdminVidpic/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Viseoapic videopicVM,IFormFile Photo)
        {
            if (ModelState.IsValid)
            {

                if (Photo != null)
                {
                    string imgName = Guid.NewGuid() + Photo.FileName;
                    string folderURl = Path.Combine(_webHost.WebRootPath, "uploads");
                    string imageFolder = Path.Combine(folderURl, imgName);
                    using var fileReader = new FileStream(imageFolder, FileMode.Create);
                    Photo.CopyTo(fileReader);
                    Picture picture = new Picture()
                    {
                        Url = imgName
                    };
                    _context.Pictures.Add(picture);
                   await _context.SaveChangesAsync();

                    Viseoapic videopic = new Viseoapic()
                    {
                        CategoryId = videopicVM.CategoryId,
                        Description = videopicVM.Description,
                        Name = videopicVM.Name,
                        PictureID=picture.Id,
                    };
                    _context.Viseoapics.Add(videopic);
                   await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name",videopicVM.CategoryId);
            return View(videopicVM);
        }

        

        // GET: Dashboard/AdminVidpic/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viseoapic = await _context.Viseoapics.FindAsync(id);
            if (viseoapic == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", viseoapic.CategoryId);
            return View(viseoapic);
        }

        // POST: Dashboard/AdminVidpic/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,CategoryId,YoutubeLink,PictureID,IsFeatured")] Viseoapic viseoapic,IFormFile Photo)
        {
            if (id != viseoapic.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    if (Photo != null)
                    {
                        string imgName = Guid.NewGuid() + Photo.FileName;
                        string folderURl = Path.Combine(_webHost.WebRootPath, "uploads");
                        string imageFolder = Path.Combine(folderURl, imgName);
                        using var fileReader = new FileStream(imageFolder, FileMode.Create);
                        Photo.CopyTo(fileReader);
                        Picture picture = new Picture()
                        {
                            Url = imgName
                        };
                        _context.Pictures.Add(picture);
                        await _context.SaveChangesAsync();
                        viseoapic.PictureID = picture.Id;
                    }
                    _context.Update(viseoapic);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ViseoapicExists(viseoapic.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Name", viseoapic.CategoryId);
            return View(viseoapic);
        }

        // GET: Dashboard/AdminVidpic/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var viseoapic = await _context.Viseoapics
                .Include(v => v.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (viseoapic == null)
            {
                return NotFound();
            }

            return View(viseoapic);
        }

        // POST: Dashboard/AdminVidpic/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var viseoapic = await _context.Viseoapics.FindAsync(id);
            _context.Viseoapics.Remove(viseoapic);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ViseoapicExists(int id)
        {
            return _context.Viseoapics.Any(e => e.Id == id);
        }
    }
}
