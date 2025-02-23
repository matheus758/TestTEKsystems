using Application.Interface.Messager;
using Application.Interface.Repository;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MessengerRabbitMQ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IRabbitMQProducer _rabbitMQProducer;
        private readonly ILogger<UserController> _logger;
        private readonly IUserRepository _userService;

        public UserController(ILogger<UserController> logger, IUserRepository userService, IRabbitMQProducer rabbitMQProducer)
        {
            _logger = logger;
            _userService = userService;
            _rabbitMQProducer = rabbitMQProducer;
        }



        [HttpGet("userlist")]
        public IActionResult GetProducts()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [HttpGet("userlistAsync")]
        public async Task<ActionResult<IEnumerable<User>>> GetProductsAsync()
        {
            var users = await _userService.GetAllAsync();
            return Ok(users);
        }

        [HttpPost("adduser")]
        public IActionResult Add([FromBody] User user)
        {
            var newProduct = _userService.New(user);
            _rabbitMQProducer.SendProductMessage(newProduct, "User");
            return Ok(newProduct);
        }
        [HttpPut("updateuser")]
        public IActionResult Update([FromBody] User user)
        {
            var updatedProduct = _userService.Update(user);
            return Ok(updatedProduct);
        }

        [HttpDelete("deleteuser")]
        public IActionResult Delete([FromBody] User user)
        {
             _userService.Delete(user);

                return Ok();
        }





    }

}
