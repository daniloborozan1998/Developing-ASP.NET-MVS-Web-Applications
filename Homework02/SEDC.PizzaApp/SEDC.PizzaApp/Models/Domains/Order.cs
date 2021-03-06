using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Models.Enums;

namespace SEDC.PizzaApp.Models.Domains
{
    public class Order
    {
        public int Id { get; set; }
        public Pizza Pizza { get; set; }
        public User User { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
