using EHR.AppService;
using EHR.AppService.Dtos;
using EHR.Core.Interfaces;
using EHR.Core.Models;
using EHR.Infrastructure;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace EHR.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClaimsController : ControllerBase
    {
        private readonly IEHRService _eHRService;

        public ClaimsController(IEHRService eHRService)
        {
            _eHRService = eHRService;
        }

        [HttpPost(Name = "submit")]
        public  async Task<ActionResult> Submit([FromBody] ClaimDto claimDto)
        {
            if (claimDto == null)
            {
                return BadRequest(new {message = "Invalid submission"});
            }
            try
            {
                var mapper = MapperConfig.InsuranceClaimMapper();
                var claim = mapper.Map<Claim>(claimDto);

                var result = await _eHRService.Submit(claim);
                if (result > 0)
                {
                    return Ok(claimDto);
                }
                return StatusCode(500, new { message = "Failed to submit claim" });
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        [HttpPatch(Name="update")]
        public async Task<ActionResult> UpdateClaimStatus([FromBody] ClaimDto claimDto)
        {
            if (claimDto == null)
            {
                return BadRequest(new { message = "Invalid submission" });
            }
            try
            {
                var mapper = MapperConfig.InsuranceClaimMapper();
                var claim = mapper.Map<Claim>(claimDto);

                var result = await _eHRService.UpdateClaim(claim);
                if (result > 0)
                {
                    return Ok(claimDto);
                }
                return StatusCode(500, new { message = "Failed to update status" });
            }
            catch (Exception)
            {
                throw;
            }

        }

        [HttpGet(Name = "status")]
        public async Task<ActionResult> GetClaimStatus([FromQuery] string claimID)
        {
            if (string.IsNullOrEmpty(claimID))
            {
                return BadRequest(new { message = "ClaimID is required" });
            }
            try
            {

                var result = await _eHRService.ClaimStatus(claimID);
                if (result != null)
                {
                    var mapper = MapperConfig.InsuranceClaimMapper();
                    var claim = mapper.Map<ClaimDto>(result);
                    return Ok(claim);
                }
                return StatusCode(500, new { message = "Failed to retreive status at this time. Please try again later" });
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}