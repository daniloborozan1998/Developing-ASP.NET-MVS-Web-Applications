using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.OrderViewModels;
using SEDC.PizzaApp.ViewModels.PizzaViewModels;

namespace SEDC.PizzaApp.Refactored.Controllers
{
    public class PizzaController : Controller
    {
        private IPizzaService _pizzaService;

        public PizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }
        public IActionResult Index()
        {
            List<PizzaListViewModel> pizzaListViewmodels = _pizzaService.GetAllPizzas();
            return View(pizzaListViewmodels);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return View("BadRequest");
            }
            try
            {
                PizzaDetailsViewModel pizzaDetailsViewModel = _pizzaService.GetPizzaDetails(id.Value);
                return View(pizzaDetailsViewModel);
            }
            catch (Exception e)
            {
                return View("ExceptionPage");
            }
        }

        public IActionResult Create()
        {
            PizzaViewModel pizzaViewModel = new PizzaViewModel();
            return View(pizzaViewModel);
        }

        [HttpPost]
        public IActionResult Create(PizzaViewModel pizzaViewModel)
        {
            try
            {
                _pizzaService.CreatePizza(pizzaViewModel);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
                return View("ExceptionPage");
            }
        }

        public IActionResult ConnectionOrders(int? id)
        {
            if (id == null)
            {
                return View("BadRequest");
            }
            try
            {
                List<OrderListViewModel> orderListViewModels = _pizzaService.GetOrder(id.Value);
                return View(orderListViewModels);
            }
            catch (Exception e)
            {
                return View("ExceptionPage");
            }
        }
    }
}
