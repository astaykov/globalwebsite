using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace GlobalSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.LocalAddress = this.GetIP4Address();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private string GetIP4Address()
        {
            StringBuilder sb = new StringBuilder();


            foreach (IPAddress IPA in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                sb.AppendLine(IPA.ToString());
                sb.AppendLine("<br/>");
            }
            return sb.ToString();
        }
    }
}