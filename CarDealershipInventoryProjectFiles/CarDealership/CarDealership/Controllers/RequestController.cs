using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CarDealership.Models;

namespace CarDealership.Controllers
{
    public class RequestController : ApiController
    {
        public List<RequestForInfo> GetAllRequests()
        {
            return null;
        }

        public RequestForInfo GetSingleRequest()
        {
            return null;
        }

        public HttpResponseMessage PostNewRequest(RequestForInfo r)
        {
            return null;
        }

        public HttpResponseMessage PutEditRequest(RequestForInfo r)
        {
            return null;
        }
    }
}
