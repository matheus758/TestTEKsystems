using Application.Interface.Messager;
using Application.Interface.Repository;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MessengerRabbitMQ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRabbitMQProducer _rabbitMQProducer;
        private readonly ILogger<ProductController> _logger;
        private readonly IProductRepository _productService;
        public ProductController(ILogger<ProductController> logger, IProductRepository productService, IRabbitMQProducer rabbitMQProducer)
        {
            _logger = logger;
            _productService = productService;
            _rabbitMQProducer = rabbitMQProducer;
        }
        [HttpGet("productlist")]
        public IActionResult GetProducts()
        {
            var products = _productService.GetAll();
            return Ok(products);
        }
        [HttpGet("product/{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = _productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
        [HttpPost("addproduct")]
        public IActionResult AddProduct([FromBody] Product product)
        {
            var newProduct = _productService.New(product);
            _rabbitMQProducer.SendProductMessage(newProduct, "Product");
            return Ok(newProduct);
            //return CreatedAtRoute("GetProduct", new { id = newProduct.ProductID }, newProduct);
        }
        [HttpPut("updateproduct")]
        public IActionResult UpdateProduct([FromBody] Product product)
        {
            var updatedProduct = _productService.Update(product);
            return Ok(updatedProduct);
        }
        //[HttpDelete("deleteproduct/{id}")]
        //public IActionResult DeleteProduct(int id)
        //{
        //    var result = _productService.(id);
        //    if (result)
        //    {
        //        return Ok();
        //    }
        //    return NotFound();
        //}

        //[HttpDelete("deleteproduct")]
        //public IActionResult DeleteProduct([FromBody] Product product)
        //{
        //    var result = _productService.DeleteProduct(product);
        //    if (result)
        //    {
        //        return Ok();
        //    }
        //    return NotFound();
        //}

    }
}
