using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership.Models
{
    public class RequestForInfo
    {
        public int RequestID { get; set; }
        public int VehicleID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string BestTimeToCall { get; set; }
        public string PreferredContactMethod { get; set; }
        public string TimeframeToPurchase { get; set; }
        public string AdditionalInfo { get; set; }
        public DateTime LastContactDate { get; set; }
        public string Status { get; set; }
    }
}
