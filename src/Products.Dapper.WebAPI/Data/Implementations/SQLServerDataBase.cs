﻿using System.Data;
using System.Data.SqlClient;

namespace Products.Dapper.WebAPI.Data.Implementations
{
    public class SQLServerDataBase : IConnectionDataBase
    {
        private readonly string _connectionString;

        public SQLServerDataBase()
        {
            _connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DB_ProductsDapper;Persist Security Info=True;User ID=sa;Password=***********";
        }

        public IDbConnection GetDbConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
