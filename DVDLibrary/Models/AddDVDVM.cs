using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace DVDLibrary.Models
{
    public class AddDVDVM
    {
        public DVD Dvd { get; set; }
        public string StudioDescription { get; set; }

        // this may need to ba a string instead of a list
        public List<SelectListItem> StudioNameSelectList { get; set; }

        public List<Studio> StudioList { get; set; }

        public void CreateStudioList(List<Studio> studios)
        {
            StudioNameSelectList = new List<SelectListItem>();

            List<Studio> newStudios = studios.GroupBy(s => s.StudioName).Select(s => s.FirstOrDefault()).ToList();

            foreach (var studio in newStudios)
            {
                StudioNameSelectList.Add(
                    new SelectListItem
                    {
                        Text = studio.StudioName,
                        Value = studio.StudioId.ToString()
                    }
                );
            }
        }

        // this may need to ba a string instead of a list
        public List<SelectListItem> MPAASelectList { get; set; }

        public List<MPAA> MPAAList { get; set; }

        public void CreateMPAAList(List<MPAA> mpaas)
        {
            MPAASelectList = new List<SelectListItem>();

            List<MPAA> newMPAAs = mpaas.GroupBy(m => m.MPAARating).Select(m => m.FirstOrDefault()).ToList();

            foreach (var mpaa in newMPAAs)
            {
                MPAASelectList.Add(
                    new SelectListItem
                    {
                        Text = mpaa.MPAARating,
                        Value = mpaa.MPAARating
                    }
                );
            }
        }

        // This should be a ListBox on the View, so the user can select multiple Actors.

        // this may need to ba a string instead of a list
        public List<SelectListItem> ActorSelectList { get; set; }

        public List<Actor> ActorList { get; set; }

        public void CreateActorList(List<Actor> mpaas)
        {
            MPAASelectList = new List<SelectListItem>();

            List<Actor> newActors = mpaas.GroupBy(a => a.ActorName).Select(a => a.FirstOrDefault()).ToList();

            foreach (var actor in newActors)
            {
                ActorSelectList.Add(
                    new SelectListItem
                    {
                        Text = actor.ActorName,
                        Value = actor.ActorId.ToString()
                    }
                );

            }
        }
    }
}