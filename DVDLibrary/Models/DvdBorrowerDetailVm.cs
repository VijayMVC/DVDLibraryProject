using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DVDLibrary.Models
{
    public class DvdBorrowerDetailVM
    {
        public DVD Dvd { get; set; }
        public List<DVDBorrowerDetail> BorrowerDetails { get; set; }
        public List<Borrower> BorrowerName { get; set; }
    }
}