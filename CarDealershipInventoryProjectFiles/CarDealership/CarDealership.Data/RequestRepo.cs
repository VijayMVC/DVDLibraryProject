using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealership.Data.Config;
using CarDealership.Models;
using Dapper;

namespace CarDealership.Data
{
    public class RequestRepo
    {
        public List<RequestForInfo> GetAll()
        {
            using (SqlConnection connect = new SqlConnection(Settings.ConnectionString))
            {
                return connect.Query<RequestForInfo>("SELECT * FROM RequestForInfo").ToList();
            }
        }

        public RequestForInfo GetRequestByID(int id)
        {
            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("RequestID", id);
                return cn.Query<RequestForInfo>("SELECT * FROM RequestForInfo WHERE RequestID = @RequestID ", p).FirstOrDefault();
            }
        }

        
        // Need Add Request

        // Need Update Request

    }
}
