using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DotnetFrameworkTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        [HttpGet]
        public string Gevalue()
        {
            string sHtml = "";
            HttpWebRequest request;
            HttpWebResponse response = null;
            Stream stream = null;
            try
            {
                request = (HttpWebRequest)WebRequest.Create("https://webapplication1120210726180552.azurewebsites.net/Scripts/MOC/MOCPrint.css");
                response = (HttpWebResponse)request.GetResponse();
                stream = response.GetResponseStream();
                StreamReader sr = new StreamReader(stream, System.Text.Encoding.Default);
                sHtml = sr.ReadToEnd();
                if (stream != null) stream.Close();
                if (response != null) response.Close();
                return sHtml;
            }
            catch (Exception ee)
            {
                return ee.Message;
            }
        }
    }
}