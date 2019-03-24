using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DaiNamHungProject.Controllers
{
    public class BuffetController : Controller
    {
        // GET: Buffet
        public ActionResult Index()
        {
            return PartialView();
        }
    }
}