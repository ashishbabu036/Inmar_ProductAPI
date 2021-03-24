using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models
{
    public class Offer
    {
        private string offerName;
        private List<Product> products;
        public string OfferName { get => offerName; set => offerName = value; }
        public List<Product> Products { get => products; set => products = value; }

        public Offer(string _offerName, List<Product> _products)
        {
            OfferName = _offerName;
            Products = _products;
        }
    }
}
