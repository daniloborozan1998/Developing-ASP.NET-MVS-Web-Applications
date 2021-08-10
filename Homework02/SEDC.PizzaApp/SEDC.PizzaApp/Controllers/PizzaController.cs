using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Models.Domains;
using SEDC.PizzaApp.Models.Mappers;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = StaticDB.Pizzas;
            List<PizzaViewModel> PizzaViewModel = pizzas.Select(x => PizzaMapper.PizzaToPizzaViewModel(x)).ToList();

            ViewData["Title"] = "Pizza";

            return View(PizzaViewModel);

            
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }
            Pizza pizza = StaticDB.Pizzas.FirstOrDefault(x => x.Id == id);
            if (pizza == null)
            {
                return new EmptyResult();
            }

            ViewData["Title"] = "Pizza Details";
            

            PizzaDetailsViewModel pizzaDetailsViewModel = PizzaMapper.PizzaToDetailsViewModel(pizza);
            
            return View(pizzaDetailsViewModel);
        }


        [Route("SeePizzas")] 
        public IActionResult Redirect()
        {
            return RedirectToAction("Index");
        }
    }
}
