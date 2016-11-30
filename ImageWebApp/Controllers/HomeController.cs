using System.Web.Mvc;
using ImageWebApp.Models;

namespace ImageWebApp.Controllers
{
    public class HomeController : Controller
    {
        // default controller for basic webpage
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult AllImage()
        {
            return View(ImageSet.Instance.ImageList);
        }

        public ActionResult RandImage()
        {
            return View(ImageSet.Instance.RandomeImage());
        }
    }
}