using Application.Interface.Repository;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BidApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAll()
        {
            var result = await userRepository.GetAll();
            return Ok(result);
        }
        [HttpPut]
        public async Task<ActionResult<User>> Update(User user)
        {
            var result = await userRepository.Update(user);

            return Ok(result);
        }
        [HttpDelete]
        public async Task<ActionResult> Delete(User user)
        {
            await userRepository.Delete(user);
            return Ok();
        }
        [HttpPost]
        public async Task<ActionResult<User>> New(User user)
        {
            await userRepository.New(user);
            return Ok(user);
        }
    }
}
