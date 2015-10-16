using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DVDLibrary.Models
{
    public class DVDDetailVM
    {
        public DVD Dvd { get; set; }
        public string StudioDescription { get; set; }
        public List<DVDActorDetail> ActorDetails { get; set; } 

        public DVDDetailVM(string studioDescription)
        {
            StudioDescription = studioDescription;
        }
    }
}