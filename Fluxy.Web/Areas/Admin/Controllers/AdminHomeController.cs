using Fluxy.Misc.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fluxy.Web.Areas.Admin.Controllers
{
    [Authorize]
    public class AdminHomeController : BaseController
    {
        // GET: Admin/AdminHome
        public ActionResult Index()
        {
            return View();
        }
    }
}