using Application.Interface.Repository;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BidApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAll()
        {
            var result = await productRepository.GetAll();
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult<Product>> New(Product product)
        {
            await productRepository.New(product);
            return Ok(product);
        }
    }
}
