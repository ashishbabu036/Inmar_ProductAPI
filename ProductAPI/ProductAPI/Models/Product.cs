using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models
{
    public class Product
    {
        private string productName;
        private decimal price;
        private string description;
        public string ProductName { get => productName; set => productName = value; }
        public decimal Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }

        public Product(string _productName, decimal _price, string _description)
        {
            ProductName = _productName;
            Price = _price;
            Description = _description;
        }

        public Product()
        {

        }
    }
}
