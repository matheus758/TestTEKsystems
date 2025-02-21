using Application.Interface.Repository;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BidApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class BidController : ControllerBase
    {
        private readonly IBidRepository bidRepository;
        public BidController(IBidRepository bidRepository)
        {
            this.bidRepository = bidRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bid>>> GetAll()
        {
            var result = await bidRepository.GetAll();
            return Ok(result);
        }
        [HttpPost]
        public async Task<ActionResult<Bid>> New(Bid bid)
        {
            await bidRepository.New(bid);
            return Ok(bid);
        }
    }
}
