using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutersAndViews.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        [Route("admin/haha/souadmin")]
        public ActionResult SouAdmin()
        {
            return View();
        }
    }
}