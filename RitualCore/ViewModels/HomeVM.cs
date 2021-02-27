using RitualCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RitualCore.ViewModels
{
    public class HomeVM
    {
        public List<Viseoapic> Videos { get; set; }
        public List<Category> Categories{ get; set; }

        public Viseoapic Video { get; set; }
    }
}
