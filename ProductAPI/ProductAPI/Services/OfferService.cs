using ProductAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Services
{
    public class OfferService: IOfferService
    {
        private List<Product> Inventory;

        public OfferService()
        {
            PopulateInventory();
        }

        private void PopulateInventory()
        {
            Inventory = new List<Product>() {
                new Product("P1", 1000, "P1 Desc"),
                new Product("P2", 200,  "P2 Desc"),
                new Product("P3", 400,  "P3 Desc"),
                new Product("P4", 700,  "P4 Desc"),
                new Product("P5", 600,  "P5 Desc"),
                new Product("P6", 800,  "P6 Desc"),
            };
        }

        public List<Product> GetAllProducts() => Inventory;

        public void AddProduct(Product product)
        {
            Inventory.Add(product);
        }

        public List<Offer> GetTodaysOffers()
        {
            List<Offer> todaysOffers = new List<Offer>();
            for(int i=1;i<=4;i++)
            {
                Random random = new Random();
                List<Product> product = new List<Product>();
                int index = random.Next(0, 5);
                for(int j=1;j<=4;j++)
                {
                    if(j!=index)
                    product.Add(Inventory[j-1]);
                }
                Offer offer = new Offer("ComboPackage" + i, product);
                todaysOffers.Add(offer);
            }
            return todaysOffers;
        }
    }
}
