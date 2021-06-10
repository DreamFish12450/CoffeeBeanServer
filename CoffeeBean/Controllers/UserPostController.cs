using System.Threading.Tasks;
using CoffeeBean.dao;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeBean.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPostController : ControllerBase
    {
        private readonly IUserPostRepository _userPostRepository;

        public UserPostController(IUserPostRepository userPostRepository)
        {
            _userPostRepository = userPostRepository;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _userPostRepository.GetUserPostByUserId(id);
            return Ok(data);
        }
    }
}