using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RitualCore.Data;
using RitualCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RitualCore.Controllers
{
    public class SearchController : Controller
    {
        public readonly ApplicationDbContext _context;

        public SearchController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? id)
        {
            var videos = _context.Viseoapics.Include(x => x.Picture).AsQueryable();
            if (id.HasValue)
            {
                videos = videos.Where(x => x.CategoryId == id);
            }
            HomeVM vm = new HomeVM()
            {
                Videos = videos.ToList(),
                Categories = _context.Categories.ToList()

            };
            return View(vm);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            var videSingle = _context.Viseoapics.FirstOrDefault(x => x.Id==id);
            if (videSingle == null) return NotFound();
            HomeVM vm = new HomeVM()
            {
                Video = videSingle,
                Videos = _context.Viseoapics.Include(x => x.Picture).ToList(),
                Categories=_context.Categories.ToList()
            };
            return View(vm);
        }

    }
}
