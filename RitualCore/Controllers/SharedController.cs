using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using RitualCore.Data;
using RitualCore.Models;

namespace RitualCore.Controllers
{
    public class SharedController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IWebHostEnvironment Environment;
        public SharedController(ApplicationDbContext context, IWebHostEnvironment _environment)
        {
            Environment = _environment;
            _context = context;
        }
        [HttpPost]
        public async Task<JsonResult> UploadPicture()
        {
            var picture = Request.Form.Files;
            JsonResult result = new JsonResult(new { });
            List<object> picturesJson = new List<object>();
            for (int i = 0; i < picture.Count; i++)
            {
                var pistures = picture[i];
                var filename = Guid.NewGuid() + Path.GetExtension(pistures.FileName);
                string uploadsFolder = Path.Combine(Environment.WebRootPath, "uploads");
                string filePath = Path.Combine(uploadsFolder, filename);
                using var fileStream = new FileStream(filePath, FileMode.Create);
                await pistures.CopyToAsync(fileStream);
                Picture dbPicture = new Picture
                {
                    Url = filename
                };
                _context.Pictures.Add(dbPicture);
                await _context.SaveChangesAsync();
                picturesJson.Add(new { dbPicture.Id, pictureURL = dbPicture.Url });
            }
            result=new JsonResult(new { Data = picturesJson });

            return result;
        }
    }
}
