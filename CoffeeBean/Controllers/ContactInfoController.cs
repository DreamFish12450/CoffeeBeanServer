using System.Threading.Tasks;
using CoffeeBean.dao;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeBean.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactInfoController:ControllerBase
    {
        private readonly IContactInfoRepository _contactInfoRepository;

        public ContactInfoController(IContactInfoRepository contactInfoRepository)
        {
            _contactInfoRepository = contactInfoRepository;
        }
        [HttpGet("{noteName}")]
        public async Task<IActionResult> Get(string noteName)
        {
            var data = await _contactInfoRepository.GetContactInfoByNoteName(noteName);
            return Ok(data);
        }
       
    }
}