using System;
using System.Web.Http;

namespace WindowsService
{
    public class ReportController : ApiController
    {
        // GET
        public string GetString(Int32 id)
        {
            return "This message is returned through window service.";
        }
    }
}