﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DVDLibrary.Models
{
    public class DVD
    {
        public int DVDId { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string MPAA { get; set; }
        public string Director { get; set; }
        public int StudioID { get; set; }
    }
}
