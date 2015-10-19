using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVDLibrary.Models;

namespace DVDLibrary.Data
{
    public class DVDRepo : IDVDRepo
    {
        
        public List<DVD> GetAllDVDs()
        {
            return null;
        }

        public DVD GetDVDByTitle(string title)
        {
            return null;
        }

        public DVD GetDVDById(int id)
        {
            return null;
        }

        public int AddDVD(DVD dvd)
        {
            return 1;
        }
        
        public void RemoveDVD(int id)
        {
            
        }
        
        public List<DVDUserDetail> GetAllUserNotes(int dvdId)
        {
            return null;
        }

        public string GetStudioDescription(int studioId)
        {
            // list DVD Details Page
            return null;
        }

        public List<DVDActorDetail> GetActorDetails(int dvdId)
        {
            // list DVD Details Page
            return null;
        }

        public List<Actor> GetAllActors(int actorId)
        {
            // dropdown for DVD Details Page
            return null;
        }

        public List<MPAA> GetAllMPAA()
        {
            // dropdown for Add DVD Page
            return null;
        }

        public List<Studio> GetAllStudios()
        {
            // dropdown for Add DVD Page
            return null;
        }

    
    }
}
