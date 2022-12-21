using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ContosoCrafts.WebSite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService productService)
        {
            this.ProductService = productService;
        }

        public  JsonFileProductService ProductService { get; set; }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return
                ProductService.GetProducts();
        }

        [Route("Rate")]
        [HttpGet]
        public ActionResult Get( [FromQuery]string ProductId, int Rating)
        {
            ProductService.AddRating(ProductId, Rating);
            return Ok();

        }

    }
}
