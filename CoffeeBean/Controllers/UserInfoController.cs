using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeBean.Bean;
using CoffeeBean.dao;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeBean.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userInfoController : ControllerBase
    {
        // why readonly
        // 只在运行时求值，且能够修饰各种属性。
        // 只读不能修改
        private readonly IUserRepository _userRepository;
        public userInfoController(IUserRepository iUserRepository)
        {
           _userRepository = iUserRepository;
        }
        //ActionResult是控制器方法执行后返回的结果类型，控制器方法可以返回一个直接或间接从ActionResult抽象类继承的类型，
        //如果返回的是非ActionResult类型，控制器将会将结果转换为一个ContentResult类型。
        //默认的ControllerActionInvoker调用ActionResult.ExecuteResult方法生成应答结果。


        // GET: /HelloWorld/  
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await _userRepository.GetUserList();
            return Ok(data);
        }
        [HttpGet("{username}")]
        public async Task<IActionResult> Get(string username)
        {
            var data = await _userRepository.GetByUsernameAsync(username);
            return Ok(data);
        }
        [Route("register")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] userInfo user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _userRepository.AddUserAsync(user);
            return NoContent();
        }
    }
    
}