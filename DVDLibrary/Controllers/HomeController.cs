using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using DVDLibrary.Data;
using DVDLibrary.Models;
using Microsoft.SqlServer.Server;

namespace DVDLibrary.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllDVDs()
        {
            return View();
        }

        public ActionResult AddDVD()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDVD(AddDVDVM vm)
        {
            //redirect to Success View
            return View();
        }

        [HttpPost]
        public ActionResult ListDVDsByTitle(string title)
        {
            var repo = new DVDRepo();

            var results = repo.GetDVDByTitle(title);

            if (title == String.Empty)
            {
                return View("NoResults");
            }
            //redirect to List DVDs View
            return View(results);
        }


        public ActionResult SearchByTitle()
        {
            //redirect to List DVDs View
            return View();
        }

        public ActionResult DVDDetails(int dvdId, DVDDetailVM vm)
        {
            return View();
        }

        public ActionResult ListBorrowersByDVD(int dvdId, DvdBorrowerDetailVM vm)
        {
            return View();
        }

        public ActionResult RemoveDVD(int dvdId)
        {
            //redirect to Success View
            return View();
        }

        public ActionResult Success()
        {
            return View();
        }
    }
}