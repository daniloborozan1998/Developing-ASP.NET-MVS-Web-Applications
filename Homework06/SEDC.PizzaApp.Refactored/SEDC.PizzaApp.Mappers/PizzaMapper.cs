using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.ViewModels.PizzaViewModels;

namespace SEDC.PizzaApp.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaDDViewModel ToPizzaDDViewModel(this Pizza pizza)
        {
            return new PizzaDDViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name
            };
        }

        public static PizzaListViewModel PizzaToPizzaListViewModel(this Pizza pizza)
        {
            return new PizzaListViewModel()
            {
                Id = pizza.Id,
                Name = pizza.Name,
                IsOnPromotion = pizza.IsOnPromotion
            };
        }

        public static PizzaDetailsViewModel PizzaToDetailsViewModel(this Pizza pizza)
        {
            return new PizzaDetailsViewModel()
            {
                Id = pizza.Id,
                Name = pizza.Name,
                IsOnPromotion = pizza.IsOnPromotion
            };
        }

        public static Pizza ToPizza(this PizzaViewModel pizzaViewModel)
        {
            return new Pizza
            {
                Id = pizzaViewModel.Id,
                Name = pizzaViewModel.Name,
                IsOnPromotion = pizzaViewModel.IsOnPromotion
            };
        }
    }
}
