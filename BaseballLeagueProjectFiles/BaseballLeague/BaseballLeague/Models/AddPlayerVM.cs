using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaseballLeague.Models
{
    public class AddPlayerVM
    {
        public Player PlayerToAdd { get; set; }

        public List<SelectListItem> TeamNameSelectList { get; set; }
        public int TeamSelectedValue { get; set; }

        public AddPlayerVM()
        {
            PlayerToAdd = new Player();
            TeamNameSelectList = new List<SelectListItem>();
        }

        public void CreateTeamList(List<Team> teams)
        {
            TeamNameSelectList = new List<SelectListItem>();

            foreach (var team in teams)
            {
                TeamNameSelectList.Add(
                    new SelectListItem
                    {
                        Text = team.TeamName,
                        Value = team.TeamID.ToString()
                    }
                );
            }
        }
    }
}