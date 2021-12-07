﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using vagtplanen.Shared.Models;

namespace vagtplanen.Server.Services
{
    public class TaskClassService
    {
        private readonly string _connectionString;
        public TaskClassService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("postgres");
        }

        public static IDbConnection OpenConnection(string connStr)
        {
            var conn = new NpgsqlConnection(connStr);
            conn.Open();
            return conn;
        }

        public IEnumerable<TaskClass> Get()
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"select * from all_teamtasks";

                var list = conn.Query<TaskClass, Shift, TaskClass>(
                query,
                (t, s) =>
                {
                    t.shifts = new();
                    t.shifts.Add(s);

                    return t;
                },
                splitOn: "taskclass_id, shift_id");


                return list;
            }

        }

        public TaskClass Get(int em)
        {
            var listen = Get().First(x => x.task_id == em);
            return listen;
        }

        public TaskClass Create(TaskClass obj)
        {
            using (var conn = OpenConnection(_connectionString))
            {

                var query = @"CALL add_task(@description)";

                var values = new
                {
                    description = obj.description
                };

                conn.Execute(query, values);

                return obj;
            }
        }

        public int Delete(int id)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"CALL delete_task(@_id)";
                var value = new
                {
                    _id = id
                };
                conn.ExecuteAsync(query, value);

                return id;
            }
        }
    }
}