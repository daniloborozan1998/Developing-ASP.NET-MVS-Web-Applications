using System;
using SEDC.PizzaApp.DataAccess.Interfaces;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Mappers;
using SEDC.PizzaApp.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.PizzaViewModels;
using System.Collections.Generic;
using System.Linq;
using SEDC.PizzaApp.ViewModels.OrderViewModels;

namespace SEDC.PizzaApp.Services.Implementations
{
    public class PizzaService : IPizzaService
    {
        private IPizzaRepository _pizzaRepository;

        public PizzaService(IPizzaRepository pizzaRepository) //Dependency Injection
        {
            _pizzaRepository = pizzaRepository;
        }
        public List<PizzaDDViewModel> GetPizzasForDropdown()
        {
            //get from db
            List<Pizza> pizzasDb = _pizzaRepository.GetAll();
            //map to view models
            return pizzasDb.Select(x => x.ToPizzaDDViewModel()).ToList();
        }

        public string GetPizzaOnPromotion()
        {
            return _pizzaRepository.GetPizzaOnPromotion().Name;
        }

        public List<PizzaListViewModel> GetAllPizzas()
        {
            List<Pizza> pizzaDb = _pizzaRepository.GetAll();
            return pizzaDb.Select(x => x.PizzaToPizzaListViewModel()).ToList();
        }

        public PizzaDetailsViewModel GetPizzaDetails(int id)
        {
            Pizza pizzaDb = _pizzaRepository.GetById(id);
            if (pizzaDb == null)
            {
                throw new Exception($"The pizza with id {id} is not found");
            }

            return pizzaDb.PizzaToDetailsViewModel();
        }

        public void CreatePizza(PizzaViewModel pizzaViewModel)
        {
            Pizza pizza = pizzaViewModel.ToPizza();
            int newPizzaId = _pizzaRepository.Insert(pizza);
            if (newPizzaId <= 0)
            {
                throw new Exception("An errro occured while saving to db");
            }
        }

        public List<OrderListViewModel> GetOrder(int id)
        {
            List<Order> ordersDb = _pizzaRepository.ConnectedOrders(id);
            return ordersDb.Select(x => OrderMapper.OrderToOrderListViewModel(x)).ToList();
        }
    }
}
