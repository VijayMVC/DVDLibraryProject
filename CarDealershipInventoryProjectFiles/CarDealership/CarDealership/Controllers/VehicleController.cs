using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CarDealership.Models;
using CarDealership.Data;

namespace CarDealership.Controllers
{
    public class VehicleController : ApiController
    {
        public List<Vehicle> GetVehicleList()
        {
            var repo = new VehicleRepo();
            var results = repo.GetAll();
            return results;
        }

        public Vehicle GetSingleVehicle(int id)
        {
            return null;
        }

        public HttpResponseMessage PostAddVehicle(Vehicle v)
        {
            return null;
        }

        public HttpResponseMessage PutRemoveVehicle(int id)
        {
            return null;
        }
    }
}
