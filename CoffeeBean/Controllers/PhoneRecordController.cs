using System.Threading.Tasks;
using CoffeeBean.dao;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeBean.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhoneRecordController : ControllerBase
    {
        private readonly IPhoneRecordRepository _phoneRecordRepository;
        public PhoneRecordController(IPhoneRecordRepository phoneRecordRepository)
        {
            _phoneRecordRepository = phoneRecordRepository;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var data = await _phoneRecordRepository.GetRecordByReceiverId(id);
            return Ok(data);
        }
        [HttpGet("{id},{noteName}")]
        public async Task<IActionResult> Get(int id,string noteName)
        {
            var data = await _phoneRecordRepository.GetRecordByReceiverIdAndNoteName(id,noteName);
            return Ok(data);
        }
        
        
    }
}