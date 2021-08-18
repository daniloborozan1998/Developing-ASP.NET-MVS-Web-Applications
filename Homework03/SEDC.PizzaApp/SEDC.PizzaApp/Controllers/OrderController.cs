using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Mappers;
using SEDC.PizzaApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {

            List<Order> ordersDb = StaticDb.Orders;
            List<OrderListViewModel> orderListViewModels = ordersDb
                .Select(x => OrderMapper.OrderToOrderListViewModel(x)).ToList();

            ViewData["Message"] = $"The number of orders is: {ordersDb.Count}";
            ViewData["Title"] = "Orders list";
            ViewData["Date"] = DateTime.Now.ToShortDateString();

            ViewData["FirstUser"] = StaticDb.Users.First();

            return View(orderListViewModels); ;
        }

        [Route("{controller}/Details/{id?}")]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }
            ViewBag.Message = StaticDb.Message;
            ViewBag.User = StaticDb.Users.First();
            Order orderDb = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
            if (orderDb == null)
            {
                return View("ResourceNotFound");
            }
            OrderDetailsViewModel orderDetailsViewModel = OrderMapper.OrderToOrderDetailsViewModel(orderDb);
            return View(orderDetailsViewModel);
        }

        [Route("{controller}/JsonData")]
        public IActionResult GetJsonOrder()
        {
            Order order = new Order()
            {
                Id = 2,
                Pizza = StaticDb.Pizzas.Last(),
                User = StaticDb.Users.Last(),
                PaymentMethod = Models.Enums.PaymentMethod.Cash
            };
            return new JsonResult(order);
        }

        [Route("{controller}/BackToindex")]
        public IActionResult BackToIndexHomeController()
        {
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }
            Order orderDb = StaticDb.Orders.FirstOrDefault(x => x.Id == id);
            if (orderDb == null)
            {
                
                return View("ResourceNotFound"); 
            }
            OrderDetailsViewModel orderDetailsViewModel = OrderMapper.OrderToOrderDetailsViewModel(orderDb);
            return View(orderDetailsViewModel);
        }
    }
}
