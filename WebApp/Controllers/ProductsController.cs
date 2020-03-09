using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly JsonFileProductService _jsonFileProductService;
        
        public ProductsController(JsonFileProductService jsonFileProductService)
        {
            _jsonFileProductService = jsonFileProductService;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _jsonFileProductService.GetProducts();
        }
        
        [HttpPatch]
        public ActionResult Patch([FromBody] RatingRequest request)
        {
            _jsonFileProductService.AddRating(request.ProductId, request.Rating);

            return Ok();
        }
    }
}