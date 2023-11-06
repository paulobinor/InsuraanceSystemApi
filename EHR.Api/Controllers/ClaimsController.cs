using EHR.Api.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace EHR.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClaimsController : ControllerBase
    {
        
        private readonly ILogger<ClaimsController> _logger;

        public ClaimsController(ILogger<ClaimsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "create")]
        public  async Task<ActionResult<PolicyHolderDto>> Create([FromBody] PolicyHolderDto policyHolderDto)
        {
            return new PolicyHolderDto { DoB = DateTime.Now, Name = "create" };
            
        }
    }
}