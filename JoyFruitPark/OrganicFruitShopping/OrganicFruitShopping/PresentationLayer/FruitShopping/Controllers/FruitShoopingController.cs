using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingData;

namespace FruitShopping.Controllers
{
    public class FruitShoopingController : Controller
    {
        private FruitShoppingDbContext db = new FruitShoppingDbContext();
        
        // GET: FruitShooping
        public ActionResult Index()
        {
            return View();
        }
    }
}