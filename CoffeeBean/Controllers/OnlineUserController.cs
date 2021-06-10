using System.Threading.Tasks;
using CoffeeBean.Bean;
using CoffeeBean.dao;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeBean.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OnlineUserController:ControllerBase
    {
        private readonly IOnlineUser _ionlineUserController;

        public OnlineUserController(IOnlineUser ionlineUserController)
        {
            _ionlineUserController = ionlineUserController;
        }
        [HttpGet("{currentName}")]
        public async Task<IActionResult> Get(string currentName)
        {
            var data = await _ionlineUserController.GetOneOnline(currentName);
            return Ok(data);
        }
        [Route("addUser")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] OnlineUser user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _ionlineUserController.AddOnlineUserAsync(user);
            return NoContent();
        }

        [Route("deleteUser")]
        [HttpPost]
      
        public async Task<IActionResult> Get(string name,int su)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _ionlineUserController.DeleteOnlineUserAsync(name);
            return NoContent();
        }
    }
}