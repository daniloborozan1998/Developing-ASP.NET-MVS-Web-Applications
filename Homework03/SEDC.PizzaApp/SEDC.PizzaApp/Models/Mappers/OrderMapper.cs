﻿using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.Mappers
{
    public static class OrderMapper
    {
        public static OrderDetailsViewModel OrderToOrderDetailsViewModel(Order order)
        {
            return new OrderDetailsViewModel
            {
                PizzaName = order.Pizza.Name,
                UserFullName = $"{order.User.FirstName} {order.User.LastName}",
                PaymentMethod = order.PaymentMethod,
                Price = (double)(order.Pizza.IsOnPromotion ? (order.Pizza.Price - ((15 / 100) * order.Pizza.Price)) : order.Pizza.Price),
                UserAddress = order.User.Address,
                Delivered = order.Delivered
            };
        }

        public static OrderListViewModel OrderToOrderListViewModel(Order order)
        {
            return new OrderListViewModel
            {
                PizzaName = order.Pizza.Name,
                UserFullName = $"{order.User.FirstName} {order.User.LastName}"
            };
        }
    }
}
