﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SEDC.PizzaApp.Models.Enums;

namespace SEDC.PizzaApp.Models.ViewModels
{
    public class PizzaDetailsViewModel
    {
        public string PizzaName { get; set; }
        public double Price { get; set; }
        public PizzaSize PizzaSize { get; set; }
    }
}
