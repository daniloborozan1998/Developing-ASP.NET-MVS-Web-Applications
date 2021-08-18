using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Models.Mappers;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Pizza";
            List<Pizza> pizzas = StaticDb.Pizzas;
            List<PizzaDetailsViewModel> pizzaViewModels = pizzas.Select(x => PizzaMapper.PizzaDetailsViewModel(x)).ToList();
            return View(pizzaViewModels);
        }

        public IActionResult Details(int? id)
        {
            ViewData["Title"] = "Details";
            if (id == null)
            {
                return new EmptyResult();
            }
            Pizza pizza = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);
            if (pizza == null)
            {
                return new EmptyResult();
            }
            
            PizzaDetailsViewModel pizzaDetailsViewModel = PizzaMapper.PizzaDetailsViewModel(pizza);
            ViewBag.PizzaViewModel = pizzaDetailsViewModel;
            return View(pizzaDetailsViewModel);
        }
        [Route("SeePizzas")] //localhost:[port]/SeePizzas
        public IActionResult Redirect()
        {
            return RedirectToAction("Index");
        }
    }
}
