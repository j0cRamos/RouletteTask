using System;
using Dapper;
using Roulette.Context;
using System.Data;
using Roulette.Contracts;
using Roulette.Dto;
using Roulette.Entities;

namespace Roulette.Repository
{
	public class SpinRepository : ISpinRepository

	{

        private readonly DatabaseContext _databaseContext;

        public SpinRepository()
        {
        }

        public async Task CreateSpin(SpinForCreationDto spinForCreationDto)
        {
            var query = "INSERT INTO Spins (SpinNumber) VALUES (@SpinNumber)";

            var parameters = new DynamicParameters();

            parameters.Add("SpinNumber", spinForCreationDto.SpinNumber, DbType.String);

            using (var connection = _databaseContext.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task CreatePlaceBet(PlaceBetForCreationDto placeBetForCreationDto)
        {
            var query = "INSERT INTO PlaceBet (Place, BetAmount) VALUES (@Place, @BetAmount)";

            var parameters = new DynamicParameters();

            parameters.Add("Place", placeBetForCreationDto.Place, DbType.String);
            parameters.Add("BetAmount", placeBetForCreationDto.Place, DbType.Int32);

            using (var connection = _databaseContext.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<IEnumerable<Spin>> GetSpins()
        {
            var query = "SELECT * FROM Spins";

            using (var connection = _databaseContext.CreateConnection())
            {
                var spins = await connection.QueryAsync<Spin>(query);

                return spins.ToList();
            }
        }
    }
}

