using CastingCallAPI.Domain.Interfaces;
using CastingCallAPI.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CastingCallAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastingCallController : ControllerBase
    {
        private readonly ICastingCallRepository _repo;
        public CastingCallController(ICastingCallRepository repo)
        {
            _repo = repo;
        }

        [HttpGet("casting-calls/{userId}")]
        public async Task<IActionResult>GetCastingCalls(Guid userId)
        {
            var castingCalls = await _repo.GetCastingCallsAsync(userId);
            return Ok(castingCalls);
        }

        [HttpPost]
        public async Task<IActionResult>AddCastingCall(CastingCallDTO castingCall)
        {
            if(castingCall == null)
            {
                return BadRequest(new { code = 404, message = "Bad Request", status = false });
            }
            await _repo.AddCastingCallAsync(castingCall);
            return Ok(new { code = 200, message = "Created new casting call", status = true });

        }

    }
}
