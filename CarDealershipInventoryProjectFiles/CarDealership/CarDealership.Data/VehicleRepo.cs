using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealership.Data.Config;
using CarDealership.Models;
using Dapper;

namespace CarDealership.Data
{
    public class VehicleRepo
    {
        public List<Vehicle> GetAll()
        {
            var results = new List<Vehicle>();
            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                results = cn.Query<Vehicle>("SELECT * FROM Vehicle").ToList();
            }
            return results;
        }
    }
}
