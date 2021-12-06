﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace vagtplanen.Server.Services
{
    public class ShiftService
    {
        private readonly string _connectionString;
        public ShiftService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("postgres");
        }

        public static IDbConnection OpenConnection(string connStr)
        {
            var conn = new NpgsqlConnection(connStr);
            conn.Open();
            return conn;
        }

        public async Task<IEnumerable<Shift>> Get()
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"SELECT * FROM all_shifts";

                var result = await conn.QueryAsync<Shift, Volunteer, Shared.Models.Task, Shift>(query, (s, v, t) => {
                    if (v == null)
                        s.volunteer = new();
                    else
                        s.volunteer = v;
                    s.task = t;
                    return s;
                }, splitOn: "shift_id, volunteer_id, task_id");
                return result.ToList();
            }
        }

        public async Task<Shift> Get(int id)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"SELECT * FROM shift WHERE shift_id = '{0}'";
                var result = await conn.QueryFirstOrDefaultAsync<Shift>(query, id);
                return result;
            }
        }

        public Shift Create(Shift obj)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"CALL add_shift(@start_t, @end_t, @taskid)";
                var values = new
                {
                    start_t = obj.start_time,
                    end_t = obj.end_time,
                    taskid = obj.task.task_id
                };

                conn.ExecuteAsync(query, values);
                return obj;
            }
        }

        public int Delete(int id)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"CALL delete_shift(@_id)";
                var values = new
                {
                    _id = id
                };

                conn.ExecuteAsync(query, values);
                return id;
            }
        }
    }
}
