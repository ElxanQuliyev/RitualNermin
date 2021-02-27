using Microsoft.AspNetCore.Mvc;
using RitualCore.Data;
using RitualCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RitualCore.Controllers
{
    public class VideoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail(int? id)
        {
            return View();
        }

        private IActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }
    }
}
