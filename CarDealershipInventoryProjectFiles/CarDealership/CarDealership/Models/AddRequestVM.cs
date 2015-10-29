using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarDealership.Models
{
    public class AddRequestVM
    {
        public Vehicle Vehicle { get; set; }
        public RequestForInfo Request { get; set; }
    }
}