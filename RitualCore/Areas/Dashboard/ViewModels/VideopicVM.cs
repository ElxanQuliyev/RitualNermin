using RitualCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RitualCore.Areas.Dashboard.ViewModels
{
    public class VideopicVM
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public bool IsFeatured { get; set; }
        public string Description { get; set; }
        public string VideoPicture { get; set; }

        public List<Category> Categories { get; set; }
    }
}
