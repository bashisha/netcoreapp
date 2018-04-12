using System;
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
            string signedRequest =HttpContext.Request.Form["signed_request"];

            //string signedRequestParam = Request.Params["signed_request"];            
            string payload = signedRequest.Split('.')[1];
            string expectedSignature = signedRequest.Split('.')[0];

            var model = new CreditCardViewModel
            {
                Name = "Test Credit Card",
                Addresses = new string[] { "Address1", "Address2" },
                SelectedAddress = expectedSignature;
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
                Name = "Test Credit Card",
                Addresses = new string[] { "Address1", "Address2" }
            };
            return View(model);
        }

        public IActionResult Confirmation()
        {
            var model = new CreditCardViewModel
            {
                Name = "Test Credit Card",
                Addresses = new string[] { "Address1", "Address2" }
            };
            return View(model);
        }

        public void Finish()
        {
            var model = new CreditCardViewModel
            {
                Name = "Test Credit Card",
                Addresses = new string[] { "Address1", "Address2" }
            };
            //return View(model);
        }

    }
}