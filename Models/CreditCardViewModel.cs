using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreapp.Models
{
    public class CreditCardViewModel
    {
        public CreditCardViewModel() { }
        public string CustomerName { get; set; }
        public string TotalAssets { get; set; }
        public string CustomerValue { get; set; }
        public string SolicitationPre { get; set; }
        public string AuthenticationLevel { get; set; }
        public string CardNumber { get; set; }
        public Address[] Addresses { get; set; }
        public bool IsExpeditedDelivery { get; set; }
        public string SelectedAddress { get; set; }
        public bool IsDeliveryStandard { get; set; }

    }
}
