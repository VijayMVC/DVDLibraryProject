using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseballLeague.Data;
using BaseballLeague.Models;

namespace BaseballLeague.Controllers
{
    public class PlayerController : Controller
    {
        public ActionResult AddPlayer()
        {
            var playerRepo = new PlayersRepo();
            var teamRepo = new TeamRepo();
            var vm = new AddPlayerVM();

            vm.CreateTeamList(teamRepo.GetTeams());

            return View("AddPlayer", vm);
        }
    }
}