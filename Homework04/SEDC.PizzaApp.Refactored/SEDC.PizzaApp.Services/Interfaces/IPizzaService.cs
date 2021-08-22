using SEDC.PizzaApp.ViewModels.PizzaViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.Services.Interfaces
{
    public interface IPizzaService
    {
        List<PizzaListViewModel> GetAllPizzas();
        PizzaDetailsViewModel GetPizzaDetails(int id);
        void CreatePizza(PizzaViewModels pizzaViewModel);

        
    }
}