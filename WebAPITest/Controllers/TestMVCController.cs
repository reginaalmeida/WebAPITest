using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAPITest.Models;

namespace WebAPITest.Controllers
{
    public class TestMVCController : Controller
    {
        APIExDBEntities db = new APIExDBEntities();
        // GET: TestMVC
        public ActionResult Index()
        {           
            ViewBag.CustomerCategoriesID = new SelectList(db.CustomerCategoriesTbls, "CustomerCategoriesID", "CustomerCategoriesName");
            return View();

        }
    }
}