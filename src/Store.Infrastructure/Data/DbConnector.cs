﻿using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Store.Infrastructure.Data
{
    public class DbConnector
    {
        private readonly IConfiguration _configuration;

        protected DbConnector(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection CreateConnection()
        {
            string _connectionString = _configuration.GetConnectionString("DatabaseConnection");
            return new SqlConnection(_connectionString);
        }
    }
}
