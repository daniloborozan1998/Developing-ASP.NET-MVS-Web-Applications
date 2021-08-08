using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Models.Domain;

namespace SEDC.PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            List<Orders> ordersList = StaticDb.Order;
            return View(ordersList);
        }

        [Route("Details/{id?}")]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }

            List<Orders> orders = StaticDb.Order;
            if (orders == null)
            {
                return new EmptyResult();
            }
            return View(orders);
        }

        [Route("Order/Json")]
        public IActionResult GetJsonBook()
        {
            List<Orders> orderList = StaticDb.Order;
            return new JsonResult(orderList);
        }

        [Route("SeeOrders")] 
        public IActionResult Redirect()
        {
            return RedirectToAction("Index");
        }
    }
}
