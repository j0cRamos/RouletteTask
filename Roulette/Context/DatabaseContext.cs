using System;
using System.Data;
using System.Data.SqlClient;

namespace Roulette.Context
{
	public class DatabaseContext
	{
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DatabaseContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("SqlConnection");
        }

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}

