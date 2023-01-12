using System;
using Microsoft.AspNetCore.Mvc;
using Roulette.Contracts;
using Roulette.Dto;

namespace Roulette.Controllers
{
    [Route("api/spins")]
    [ApiController]
    public class SpinsController : Controller
    {
        private readonly ISpinRepository _spinRepository;

        public SpinsController(ISpinRepository spinRepository)
        {
            _spinRepository = spinRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetSpins()
        {
            var spins = await _spinRepository.GetSpins();

            return Ok(spins);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePlaceBet([FromBody] PlaceBetForCreationDto placeBetForCreationDto)
        {
            await _spinRepository.CreatePlaceBet(placeBetForCreationDto);

            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSpin([FromBody] SpinForCreationDto spinBetForCreationDto)
        {
            await _spinRepository.CreateSpin(spinBetForCreationDto);

            return Ok();
        }
    }
}

