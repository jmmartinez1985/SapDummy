using SapApiDummy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SapApiDummy.Controllers
{
    public class SapDummyController : ApiController
    {
        [HttpGet]
        public dynamic existItem([FromUri] int productKey) {
            return new { exist = true, available = 10 };
        }

        [HttpGet]
        [HttpPost]
        public dynamic sendPayment([FromBody] PaymentRQ payment )
        {
            return new { message ="transaction completed"};
        }
    }
}
