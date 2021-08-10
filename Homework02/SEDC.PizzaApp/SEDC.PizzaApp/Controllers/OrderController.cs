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
    public class OrderController : Controller
    {
        public IActionResult Index()
        {

            List<Order> ordersDb = StaticDB.Orders;
            List<OrderListViewModel> orderListViewModels = ordersDb
                .Select(x => OrderMappers.OrderToOrderListViewModel(x)).ToList();

            
            ViewData["Message"] = $"The number of orders is: {ordersDb.Count}";
            ViewData["Title"] = "Orders list";
            ViewData["Date"] = $"Date: {DateTime.Now.ToShortDateString()}";

            ViewData["FirstUser"] = StaticDB.Users.First();

            return View(orderListViewModels);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }
            ViewBag.Message = "You are on the order details page";
            ViewBag.User = StaticDB.Users.First();
            
            Order orderDb = StaticDB.Orders.FirstOrDefault(x => x.Id == id);
            if (orderDb == null)
            {
                return new EmptyResult();
            }
            
            OrderDetailsViewModel orderDetailsViewModel = OrderMappers.OrderToOrderDetailsViewModel(orderDb);
            return View(orderDetailsViewModel);
        }
    }
}
