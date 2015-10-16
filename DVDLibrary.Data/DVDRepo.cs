using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVDLibrary.Models;

namespace DVDLibrary.Data
{
    public class DVDRepo
    {
        public List<DVD> GetAllDVDs
        {
            
        }

        public DVD GetDVDByTitle(string title)
        {
            
        }

        public DVD GetDVDById(int id)
        {
            
        }

        public void AddDVD(DVD dvd)
        {
            
        }

        public void RemoveDVD(int id)
        {
            
        }

        List<DVDUserDetail> GetAllUserNotes(int dvdId)
        {
            
        }

        string GetStudioDescription(int studioId)
        {
            // list DVD Details Page
        }

        List<DVDActorDetail> GetActorDetails(int dvdId)
        {
            // list DVD Details Page
        }

        List<Actor> GetAllActors(int actorId)
        {
            // dropdown for DVD Details Page
        }

        List<MPAA> GetAllMPAA()
        {
            // dropdown for Add DVD Page
        }

        List<Studio> GetAllStudios()
        {
            // dropdown for Add DVD Page
        }
    }
}
