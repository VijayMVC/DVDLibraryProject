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
                results = cn.Query<Vehicle>("SELECT * FROM Vehicle WHERE isAvailable = 1").ToList();
            }
            return results;
        }

        public Vehicle GetVehicleByID(int id)
        {
            var result = new Vehicle();
            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("VehicleID", id);
                result = cn.Query<Vehicle>("SELECT * FROM Vehicle WHERE VehicleID = @VehicleID ", p).FirstOrDefault();
            }

            return result;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            int available = Convert.ToInt32(vehicle.IsAvailable);

            using (var connect = new SqlConnection(Settings.ConnectionString))
            {
                var command = new SqlCommand("INSERT INTO Vehicle " +
                                             "(AdTitle, Description, Make, Milage, IsAvailable, Price, UrlPicture, Year) " +
                                             "VALUES (@AdTitle, @Description, @Make, @Milage, @IsAvailable, @Price, @UrlPicture, @Year)", connect);
                command.Parameters.Add(new SqlParameter("AdTitle", vehicle.AdTitle));
                command.Parameters.Add(new SqlParameter("Description", vehicle.Description));
                command.Parameters.Add(new SqlParameter("Make", vehicle.Make));
                command.Parameters.Add(new SqlParameter("Milage", vehicle.Milage));
                command.Parameters.Add(new SqlParameter("IsAvailable", available));
                command.Parameters.Add(new SqlParameter("Price", vehicle.Price));
                command.Parameters.Add(new SqlParameter("UrlPicture", vehicle.UrlPicture));
                command.Parameters.Add(new SqlParameter("Year", vehicle.Year.Date));

                connect.Open();

                command.ExecuteNonQuery();
            }
        }

        public void RemoveVehicle(int id)
        {
            using (var connect = new SqlConnection(Settings.ConnectionString))
            {
                var p = new DynamicParameters();
                p.Add("VehicleID", id);

                var command = new SqlCommand("UPDATE Vehicle " +
                                             "SET IsAvailable = 0 " +
                                             "WHERE VehicleID = @VehicleID");

                connect.Open(); 

                command.ExecuteNonQuery();
            }
        }
    }
}
