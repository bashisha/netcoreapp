using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreapp.Models
{
    public class CreditCardViewModel
    {
        public CreditCardViewModel() { }
        public string Name { get; set; }
        public string[] Addresses { get; set; }
        public string DeliveryMethod { get; set; }
        public string SelectedAddress { get; set; }
        public bool IsDeliveryStandard { get; set; }

    }
}
