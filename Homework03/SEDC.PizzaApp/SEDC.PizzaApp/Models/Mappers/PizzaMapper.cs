using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Models.Mappers
{
    public class PizzaMapper
    {
        public static PizzaDetailsViewModel PizzaDetailsViewModel(Pizza pizza)
        {
            return new PizzaDetailsViewModel()
            {
                Id = pizza.Id,
                Name = pizza.Name,
                PizzaSize = pizza.PizzaSize,
                Price = pizza.HasExtra ? (pizza.Price + 10) : pizza.Price,
                IsOnPromotion = pizza.IsOnPromotion
            };
        }
    
    }
}
