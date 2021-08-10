using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Models.Domains;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Models.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaViewModel PizzaToPizzaViewModel(Pizza pizza)
        {
            return new PizzaViewModel()
            {
                PizzaName = pizza.Name,
                PizzaSize = pizza.PizzaSize,
                Price = pizza.HasExtras ? (pizza.Price + 10) : pizza.Price
            };
            
        }

        public static PizzaDetailsViewModel PizzaToDetailsViewModel(Pizza pizza)
        {
            return new PizzaDetailsViewModel()
            {
                PizzaName = pizza.Name,
                PizzaSize = pizza.PizzaSize,
                Price = pizza.HasExtras ? (pizza.Price + 10) : pizza.Price
            };

        }
    }
}
