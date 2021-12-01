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
    public class VolunteerService
    {
        private readonly string _connectionString;
        public VolunteerService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("postgres");
        }

        public static IDbConnection OpenConnection(string connStr)
        {
            var conn = new NpgsqlConnection(connStr);
            conn.Open();
            return conn;
        }

        public IEnumerable<Volunteer> Get()
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"select * from all_vol";


                var list = conn.Query<Volunteer, Shift, Coupon, Volunteer>(
                query,
                (v, s, c) =>
                {
                    v.coupons = new(); v.shifts = new();
                    v.shifts.Add(s);
                    v.coupons.Add(c);
                    return v;
                },
                splitOn: "volunteer_id, shift_id, coupon_id");

                var listVol = list.GroupBy(v => v.volunteer_id).Select(g =>
                {
                    var groupedList = g.First();
                    groupedList.shifts = g.Select(v => v.shifts.Single()).ToList();
                    groupedList.coupons = g.Select(v => v.coupons.Single()).ToList();
                    groupedList.shifts.RemoveAll(x => x == null);
                    groupedList.coupons.RemoveAll(x => x == null);
                    return groupedList;
                });
                return listVol;
            }

        }

        public Volunteer Get(string un)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"select * from all_vol where username = @username";
                var values = new { username = un };

                var list = conn.Query<Volunteer, Shift, Coupon, Volunteer>(
                query,
                (v, s, c) =>
                {
                    v.coupons = new(); v.shifts = new();
                    v.shifts.Add(s);
                    v.coupons.Add(c);
                    return v;
                },
                splitOn: "volunteer_id, shift_id, coupon_id", param: values);

                var listVol = list.GroupBy(v => v.volunteer_id).Select(g =>
                {
                    var groupedList = g.First();
                    groupedList.shifts = g.Select(v => v.shifts.Single()).ToList();
                    groupedList.coupons = g.Select(v => v.coupons.Single()).ToList();
                    groupedList.shifts.RemoveAll(x => x == null);
                    groupedList.coupons.RemoveAll(x => x == null);
                    return groupedList;
                });
                return listVol.First();
            }
        }
        public Volunteer Create(Volunteer obj)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"CALL add_volunteer(@first_name, @last_name, @mobile, @username, @password)";
                var values = new
                {
                    first_name = obj.first_name,
                    last_name = obj.last_name,
                    mobil = obj.mobile,
                    username = obj.username,
                    password = obj.password
                };

                conn.ExecuteAsync(query, values);
                return obj;
            }
        }

        public Volunteer Update(Volunteer obj)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"CALL edit_volunteer(@id, @first_name, @last_name, @mobil)";
                var values = new
                {
                    id = obj.volunteer_id,
                    first_name = obj.first_name,
                    last_name = obj.last_name,
                    mobil = obj.mobile
                };

                conn.ExecuteAsync(query, values);
                return obj;
            }
        }

        public int Delete(int id)
        {
            using (var conn = OpenConnection(_connectionString))
            {
                var query = @"CALL delete_volunteer(@_id)";
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
