using Application.Interface.Repository;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BidApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class BidProductController : ControllerBase
    {
        private readonly IBidProductRepository bidProductRepository;
        public BidProductController(IBidProductRepository bidProductRepository)
        {
            this.bidProductRepository = bidProductRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BidProduct>>> GetAll()
        {
            var result = await bidProductRepository.GetAll();
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult<BidProduct>> New(BidProduct bidProduct)
        {
            await bidProductRepository.New(bidProduct);
            return Ok(bidProduct);
        }
    }
}
