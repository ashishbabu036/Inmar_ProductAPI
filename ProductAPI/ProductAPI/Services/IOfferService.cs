using ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Services
{
    public interface IOfferService
    {
        List<Product> GetAllProducts();
        List<Offer> GetTodaysOffers();
        void AddProduct(Product product);
    }
}
