﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netcoreapp.Models;

namespace netcoreapp.Controllers
{
    public class CreditController : Controller
    {
      
        // GET: Credit
        public IActionResult Index()
        {
            var model = new CreditCardViewModel
            {
                CardNumber = "Test Credit Card",
                Addresses = new string[] { "Address1", "Address2" }
            };
            return View(model);
        }

        public IActionResult BackToPrev()
        {
            return View();
        }

        public IActionResult Shipping()
        {
            var model = new CreditCardViewModel
            {
                CardNumber = "Test Credit Card",
                Addresses = new string[] { "Address1", "Address2" }
            };
            return View(model);
        }

        public IActionResult Confirmation()
        {
            var model = new CreditCardViewModel
            {
                CardNumber = "Test Credit Card",
                Addresses = new string[] { "Address1", "Address2" }
            };
            return View(model);
        }

        public void Finish()
        {
            var model = new CreditCardViewModel
            {
                CardNumber = "Test Credit Card",
                Addresses = new string[] { "Address1", "Address2" }
            };
            //return View(model);
        }
    }
}