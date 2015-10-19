using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DVDLibrary.Data.Config;
using DVDLibrary.Models;

namespace DVDLibrary.Data
{
    public class DVDRepo : IDVDRepo
    {
        
        public List<DVD> GetAllDVDs()
        {
            return null;
        }

        public List<DVD> GetDVDByTitle(string title)
        {
            var results = new List<DVD>();

            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                var d = new DynamicParameters();
                d.Add("DVDTitle", title);
                d.Add("InCollection", 1);
                results = cn.Query<DVD>("SELECT * FROM DVDs WHERE Title LIKE '%' + @DVDTitle + '%' AND IsInCollection = @InCollection", d).ToList();
            }
            return results;
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

        public List<Actor> GetAllActors()
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
