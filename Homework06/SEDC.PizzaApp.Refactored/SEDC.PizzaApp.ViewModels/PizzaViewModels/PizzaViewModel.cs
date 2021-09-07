using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using SEDC.PizzaApp.Domain.Enums;

namespace SEDC.PizzaApp.ViewModels.PizzaViewModels
{
    public class PizzaViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Pizza Name")]
        public string Name { get; set; }
        [Display(Name = "Pizza Size")]
        public PizzaSizeEnum PizzaSize { get; set; }
        [Display(Name = "Is on Promotion")]
        public bool IsOnPromotion { get; set; }
    }
}
