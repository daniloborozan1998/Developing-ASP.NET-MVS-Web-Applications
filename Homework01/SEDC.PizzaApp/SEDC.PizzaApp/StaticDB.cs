using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Models.Domain;

namespace SEDC.PizzaApp
{
    public static class StaticDb
    {
        public static List<Pizza> Pizzas = new List<Pizza>
        {
            new Pizza
            {
                Id = 1,
                Name = Models.Enum.Pizzas.Capri,
                Price = 350,
                IsOnPromotion = true
            },
            new Pizza
            {
                Id = 2,
                Name = Models.Enum.Pizzas.Margarita,
                Price = 380,
                IsOnPromotion = false
            }
        };

        public static List<Orders> Order = new List<Orders>
        {
            new Orders
            {
                Id = 1,
                ContactName = "Danilo Borozan",
                TypeofPizza = Models.Enum.Pizzas.Prsuto,
                Municipality = "Karpos2",
                Phone = 38971254795
            },
            new Orders
            {
                Id = 1,
                ContactName = "Anamarija Risteska",
                TypeofPizza = Models.Enum.Pizzas.Vegi,
                Municipality = "Taftalidze",
                Phone = 389712323444
            }
    };


    }
}
