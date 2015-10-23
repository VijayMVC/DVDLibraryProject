using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BaseballLeague.Data;
using BaseballLeague.Models;
using System.Configuration;

namespace BaseballLeague.Controllers
{
    public class PlayerController : Controller
    {
        public static readonly string Mode = ConfigurationManager.AppSettings["Mode"];
        private IPlayerRepo _playerRepo;
        private ITeamRepo _teamRepo;

        public PlayerController()
        {
            if (Mode == "DB")
            {
                _playerRepo = new PlayersRepo();
                _teamRepo = new TeamRepo();
            }
            else
            {
                _playerRepo = new PlayerMockRepo();
                
            }
        }

        public ActionResult AddPlayer()
        {
            var vm = new AddPlayerVM();
            
            vm.CreateTeamList(_teamRepo.GetTeams());
            vm.CreatePositionList(_playerRepo.GetPositions());

            return View("AddPlayer", vm);
        }

        [HttpPost]
        public ActionResult AddPlayer(AddPlayerVM vm)
        {
            if (ModelState.IsValid)
            {

                Player player = _playerRepo.AddPlayer(vm.PlayerToAdd);
                
                return View("AddPlayerSuccess", player);
            }

            else
            {
                vm.CreateTeamList(_teamRepo.GetTeams());
                vm.CreatePositionList(_playerRepo.GetPositions());
                return View("AddPlayer", vm);
            }
        }
    }
}