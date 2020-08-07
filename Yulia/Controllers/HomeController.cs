using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yulia.Models;
using System.Text;
using System.Web.Services.Description;

namespace Yulia.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            var m = new ResultModel();
            StreamReader stream = new StreamReader(file.InputStream);
            string text = stream.ReadToEnd();
            var result = VigenereCipher.VCode(text, "скорпион", false);
            m.TextInfo = result;
            return View("~/Views/Home/Result.cshtml", m);

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
    }
}