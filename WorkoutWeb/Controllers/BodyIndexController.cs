using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorkoutWeb.Controllers
{
    public class BodyIndexController : Controller
    {
        // GET: BodyIndex
        public ActionResult Index()
        {
            return View();
        }
    }
}