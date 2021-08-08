using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.Domain
{
    public class Orders
    {
        public int Id { get; set; }
        public string ContactName { get; set; }
        public Enum.Pizzas TypeofPizza { get; set; }
        public string Municipality { get; set; }
        public double Phone { get; set; }

        
    }
}
