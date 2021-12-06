using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace vagtplanen.Server.Services
{
    public class CoordinatorService
    {
        private readonly string _connectionString;
        public CoordinatorService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("postgres");
        }

        //LINK HERTIL
        public static IDbConnection OpenConnection(string connStr)
        {
            var conn = new NpgsqlConnection(connStr);
            conn.Open();
            return conn;
        }

        public async Task<IEnumerable<Coordinator>> Get()
        {
            using (var conn = OpenConnection(_connectionString))
            {
                //Brug view hertil
                var query = "SELECT * FROM all_coordinators;";
                var result = await conn.QueryAsync<Coordinator>(query);
                return result;
            }
        }

        public async Task<Coordinator> Get(string e)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var values = new { email = e };
                var query = @"SELECT * FROM all_coordinators WHERE email = @email";
                var result = await conn.QueryFirstOrDefaultAsync<Coordinator>(query, values);
                return result;
            }
        }

        //public Coordinator CreateCoordinator(Coordinator obj)
        //{
        //    using (var conn = OpenConnection(_connectionString))
        //    {
        //        var query = @"CALL add_coordinator(@first_name, @last_name, @mobile, @email, @address, @gender, @cpr @password)";
        //        var values = new
        //        {
        //            first_name = obj.first_name,
        //            last_name = obj.last_name,
        //            mobil = obj.mobile,
        //            email = obj.email,
        //            address = obj.address,
        //            gender = obj.gender,
        //            cpr = obj.cpr,
        //            password = obj.password
        //        };

        //        conn.ExecuteAsync(query, values);
        //        return obj;
        //    }
        //}
    }
}
