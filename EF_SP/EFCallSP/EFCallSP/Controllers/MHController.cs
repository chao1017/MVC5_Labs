using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFCallSP.Models;

namespace EFCallSP.Controllers
{
    public class MHController : Controller
    {
        private CTCI_MH_DBEntities db = new CTCI_MH_DBEntities();

        // GET: MH
        public ActionResult Index()
        {
            var result = db.s_gmh_get_leave_form_data("54CA389E-2A66-4869-BDB1-E933505A3678", "9933");

            return View(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}