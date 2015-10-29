using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
    public class PublicController : Controller
    {
        // GET: Public
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListAllCars()
        {
            return View();
        }

        public ActionResult ListCarDetails(int id)
        {
            return View();
        }

        public ActionResult AddRequestInfo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddRequestInfo(RequestForInfo r)
        {
            return View();
        }


    }
}