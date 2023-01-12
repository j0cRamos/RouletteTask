using System;
using Roulette.Dto;
using Roulette.Entities;

namespace Roulette.Contracts
{
	public interface ISpinRepository
	{
        public Task<IEnumerable<Spin>> GetSpins();
        public Task CreateSpin(SpinForCreationDto spinForCreationDto);
        public Task CreatePlaceBet(PlaceBetForCreationDto placeBetForCreationDto);

    }
}

