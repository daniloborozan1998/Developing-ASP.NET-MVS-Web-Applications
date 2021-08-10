using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Models.Enums;

namespace SEDC.PizzaApp.Models.Domains
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsOnPromotion { get; set; }
        public PizzaSize PizzaSize { get; set; }
        public bool HasExtras { get; set; }
    }
}
