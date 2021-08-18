using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SEDC.PizzaApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;
using SEDC.PizzaApp.Models.Mappers;

namespace SEDC.PizzaApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SeeUser()
        {
            List<User> userdb = StaticDb.Users;
            List<UserDetailsViewModel> users = userdb.Select(x => UserMapper.UserToUserDetailsViewModel(x)).ToList();
            return View(users);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [Route("AboutUs")]
        public IActionResult About()
        {
            StaticDb.Message = "About action changed the message!";
            return View();
        }
        [Route("ContactUs")]
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult ReturnAnotherView()
        {
            return View("NewView");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
