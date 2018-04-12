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
            return View(new CreditCardViewModel());
        }
    }
}