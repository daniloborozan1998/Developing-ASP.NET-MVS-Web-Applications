using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Models.Domains;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Models.Mappers
{
    public static class OrderMappers
    {
        public static OrderDetailsViewModel OrderToOrderDetailsViewModel(Order order)
        {
            return new OrderDetailsViewModel
            {
                PizzaName = $"{order.Pizza.Name}",
                UserFullName = $"{order.User.FirstName} {order.User.LastName}",
                UserAddress = $"{order.User.Address}",
                PaymentMethod = order.PaymentMethod,
                Price = order.Pizza.IsOnPromotion ? (order.Pizza.Price - ((15/100)*order.Pizza.Price)) : order.Pizza.Price,

            };
        }

        public static OrderListViewModel OrderToOrderListViewModel(Order order)
        {
            return new OrderListViewModel
            {
                PizzaName = $"{order.Pizza.Name}",
                UserFullName = $"{order.User.FirstName} {order.User.LastName}",
                UserAddress = $" {order.User.Address}"
            };
        }

    }
}
