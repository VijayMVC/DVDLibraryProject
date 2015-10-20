using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
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

            var results = new List<DVD>();
            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                var d = new DynamicParameters();
                d.Add("InCollection", 1);
                results = cn.Query<DVD>("SELECT * FROM DVDs WHERE IsInCollection = @InCollection", d).ToList();
            }
            return results;
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
            var results = new DVD();

            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                var d = new DynamicParameters();
                d.Add("DVDId", id);
                results = cn.Query<DVD>("SELECT * FROM DVDs WHERE DVDId = @DVDId", d).FirstOrDefault();
            }
            return results;
        }

        public int AddDVD(DVD dvd)
        {
            int dvdid;

            using (var connection = new SqlConnection(Settings.ConnectionString))
            {
                var command = new SqlCommand();
                command.CommandText = "SP_AddDVD";
                command.CommandType = CommandType.StoredProcedure;

                command.Connection = connection;
                command.Parameters.AddWithValue("@Title", dvd.Title);
                command.Parameters.AddWithValue("@Release", dvd.ReleaseDate.Date.ToString());
                command.Parameters.AddWithValue("@MPAA", dvd.MPAA);
                command.Parameters.AddWithValue("@Director", dvd.Director);
                command.Parameters.AddWithValue("@StudioID", dvd.StudioID);

                connection.Open();

                dvdid = command.ExecuteNonQuery();
            }

            return dvdid;
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
            string results = "";

            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                var d = new DynamicParameters();
                d.Add("studioID", studioId);
                results = cn.Query<string>("SELECT studioName FROM studios WHERE studioId = @studioId", d).FirstOrDefault();
            }
            return results;
        }

        public List<DVDActorDetail> GetActorDetails(int dvdId)
        {
            var results = new List<DVDActorDetail>();

            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                var d = new DynamicParameters();
                d.Add("dvdID", dvdId);
                results = cn.Query<DVDActorDetail>("SELECT * FROM dvdactordetails WHERE dvdId = @dvdId", d).ToList();
            }
            return results;
        }

        public List<string> GetActorById(List<DVDActorDetail> details)
        {
            var resultNames = new List<string>();

            using (SqlConnection cn = new SqlConnection(Settings.ConnectionString))
            {
                foreach (var detail in details)
                {
                    var d = new DynamicParameters();
                    d.Add("actorID", detail.ActorId);
                    var results = cn.Query<string>("SELECT ActorName FROM actors WHERE actorId = @actorId", d).FirstOrDefault();
                    resultNames.Add(results);
                }               
            }
            return resultNames;
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
