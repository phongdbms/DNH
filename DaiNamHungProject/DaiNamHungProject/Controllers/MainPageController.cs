using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DaiNamHungProject.Controllers
{
    public class MainPageController : Controller
    {
        // GET: MainPage
        public ActionResult Menu()
        {
            return PartialView();
        }

        public ActionResult BannerSlider()
        {
            return PartialView();
        }

        public ActionResult Hotel()
        {
            return PartialView();
        }

        public ActionResult Buffet()
        {
            return PartialView();
        }

        public ActionResult Karaoke()
        {
            return PartialView();
        }

        public ActionResult Massage()
        {
            return PartialView();
        }

        public ActionResult Estate()
        {
            return PartialView();
        }

        public ActionResult Contact()
        {
            return PartialView();
        }

        public ActionResult Map()
        {
            return PartialView();
        }
      

        public ActionResult Footer()
        {
            return PartialView();
        }

       
    }
}