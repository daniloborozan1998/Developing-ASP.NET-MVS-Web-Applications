using System;
using System.Collections.Generic;
using System.Text;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.ViewModels.PizzaViewModels;

namespace SEDC.PizzaApp.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaListViewModel PizzaToPizzaListViewModel(Pizza pizza)
        {
            return new PizzaListViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,
                PizzaSize = pizza.PizzaSize,
                Price = pizza.Price,
                IsOnPromotion = pizza.IsOnPromotion
            };
        }

        public static PizzaDetailsViewModel PizzaDetailsViewModel(this Pizza pizza)
        {
            return new PizzaDetailsViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,
                PizzaSize = pizza.PizzaSize,
                Price = pizza.Price,
                IsOnPromotion = pizza.IsOnPromotion

            };
        }

        public static Pizza ToPizza(this PizzaViewModels pizza)
        {
            return new Pizza
            {
                Id = pizza.Id,
                Name = pizza.Name,
                PizzaSize = pizza.PizzaSize,
                Price = pizza.Price,
                IsOnPromotion = pizza.IsOnPromotion
            };
        }
    }
}
