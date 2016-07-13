using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KendoUIWeb.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        public ActionResult BaseGrid()
        {
            return View();
        }
    }
}