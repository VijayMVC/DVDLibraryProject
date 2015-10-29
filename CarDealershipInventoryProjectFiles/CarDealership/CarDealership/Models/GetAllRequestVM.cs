using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace CarDealership.Models
{
    public class GetAllRequestVM
    {
        public List<RequestForInfo> ListOfRequests { get; set; } 
        public List<SelectListItem> RequestStatus { get; set; }

        public void PopulateSelectList(List<StatusOfRequest> list)
        {
            RequestStatus = new List<SelectListItem>();

            foreach (var l in list)
            {
                RequestStatus.Add(
                    new SelectListItem
                    {
                        Text = l.Status,
                        Value = l.Status
                    }
                    );
            }
        }
    }
}