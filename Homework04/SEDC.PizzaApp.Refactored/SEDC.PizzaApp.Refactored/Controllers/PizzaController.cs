using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.PizzaViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            PizzaViewModels pizzaViewModel = new PizzaViewModels();
            return View(pizzaViewModel);
        }

        [HttpPost]
        public IActionResult Create(PizzaViewModels pizzaViewModel)
        {
            try
            {
                _pizzaService.CreatePizza(pizzaViewModel);
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View("ExceptionPage");
            }
        }

    }
}