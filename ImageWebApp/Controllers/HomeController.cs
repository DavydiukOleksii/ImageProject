using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ImageWebApp.ServiceImage;
using ImageWebApp.Models;

namespace ImageWebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(Data.Instance.DataList);
        }
    }
}