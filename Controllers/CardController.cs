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
        CreditCardViewModel model = new CreditCardViewModel
        {
            CardNumber = "Card 2 (...9754)",
            TotalAssets = "$2,252,898.00",
            CustomerValue = "Very High",
            SolicitationPre = "Phone and email OK",
            CustomerName = "Richard Gere",
            Addresses = new Address[]{ new Address{
                IsSelected=true,
                MailingAddress="101 Main St, Charlotte, NC 28262" },
               new Address{IsSelected=false,MailingAddress= "50 Croby St. New York, NY 10033 " }
            }
        };
        public IActionResult Index()
        {
            return View(model);
        }

        public IActionResult BackToPrev()
        {
            return View();
        }

        public IActionResult Shipping()
        {
            model.SelectedAddress = model.Addresses.Where(x => x.IsSelected).FirstOrDefault().MailingAddress;
            return View(model);
        }

        public IActionResult Confirmation()
        {        
            return View(model);
        }

        public void Finish()
        {         
            //return View(model);
        }

    }
}