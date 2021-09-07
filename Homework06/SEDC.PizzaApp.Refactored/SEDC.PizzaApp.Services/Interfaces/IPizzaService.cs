using SEDC.PizzaApp.ViewModels.PizzaViewModels;
using System.Collections.Generic;
using SEDC.PizzaApp.ViewModels.OrderViewModels;

namespace SEDC.PizzaApp.Services.Interfaces
{
    public interface IPizzaService
    {
        List<PizzaDDViewModel> GetPizzasForDropdown();
        string GetPizzaOnPromotion();
        List<PizzaListViewModel> GetAllPizzas();
        PizzaDetailsViewModel GetPizzaDetails(int id);
        void CreatePizza(PizzaViewModel pizzaViewModel);
        List<OrderListViewModel> GetOrder(int id);
    }
}
