﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netcoreapp.Models;

namespace netcoreapp.Controllers
{
    public class CardController : Controller
    {
        public IActionResult Index()
        {
            var model = new CreditCardViewModel
            {
                Name = "Test Credit Card",
                Addresses = new string[] { "Address1", "Address2" }
            };
            return View(model);
        }
    }
}