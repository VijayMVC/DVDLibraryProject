using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DVDLibrary.Models;
using Microsoft.SqlServer.Server;

namespace DVDLibrary.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
        }

        public ActionResult GetAllDVDs()
        {

        }

        public ActionResult AddDVD()
        {

        }

        [HttpPost]
        public ActionResult AddDVD(AddDVDVM vm)
        {
            //redirect to Success View
        }

        public ActionResult GetDVDByTitle(string title)
        {
            //redirect to List DVDs View
        }

        public ActionResult DVDDetails(int dvdId, DVDDetailVM vm)
        {

        }

        public ActionResult ListBorrowersByDVD(int dvdId, DVDBorrowerDetailVM vm)
        {

        }

        public ActionResult RemoveDVD(int dvdId)
        {
            //redirect to Success View
        }
    }
}