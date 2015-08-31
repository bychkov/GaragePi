using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GarageMvc5.Controllers
{
    public class GarageController : ApiController
    {
        public string PostDoorBtn()
        {
            System.Diagnostics.Process.Start("/home/pi/Desktop/Scripts/relay.sh");
            return "Success";
        }
    }
}
