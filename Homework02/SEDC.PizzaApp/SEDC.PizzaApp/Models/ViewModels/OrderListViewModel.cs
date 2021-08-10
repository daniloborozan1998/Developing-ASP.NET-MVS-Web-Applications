using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Models.Domains;

namespace SEDC.PizzaApp.Models.ViewModels
{
    public class OrderListViewModel
    {
        public string PizzaName { get; set; }
        public string UserFullName { get; set; }
        public string UserAddress { get; set; }
        
    }
}
