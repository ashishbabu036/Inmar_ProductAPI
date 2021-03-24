using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductAPI.Models;
using ProductAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Controllers
{
    [ApiController]
    [Route("prdt")]
    public class ProductsController : ControllerBase
    {        

        private IOfferService _offerService;
        public IOfferService OfferService { get => _offerService; set => _offerService = value; }

        public ProductsController(IOfferService offerService)
        {
            OfferService = offerService;
        }
       

        [HttpGet]
        [Route("offers")]
        public IActionResult GetTodaysOffer()
        {
            return Ok(OfferService.GetTodaysOffers());
        }

        [HttpGet]
        [Route("products")]
        public IActionResult GetAllProducts()
        {
            return Ok(OfferService.GetAllProducts().OrderBy(x=>x.Price).Take(3));
        }

        [HttpGet]
        [Route("product")]
        public IActionResult GetProductWithSecondLowestPrice()
        {
            return Ok(OfferService.GetAllProducts().OrderBy(x => x.Price).Skip(1).Take(1));
        }

        [HttpPost]
        [Route("product")]
        public IActionResult AddProduct(Product product)
        {
            try
            {
                OfferService.AddProduct(product);
                return Ok();
            }
            catch (Exception ex)
            {
                return Forbid();
            }
        }
    }
}
