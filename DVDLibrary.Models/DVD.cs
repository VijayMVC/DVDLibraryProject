using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDLibrary.Models
{
    public class DVD
    {
        public int DVDId { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string MPAA { get; set; }
        public string Director { get; set; }
        public int StudioID { get; set; }
    }
}
