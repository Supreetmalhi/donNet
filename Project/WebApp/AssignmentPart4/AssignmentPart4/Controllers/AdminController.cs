using AssignmentPart4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssignmentPart4.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        public ActionResult Index()
        {
            using (var ctx = new InsuranceContext())
            {
                List<Insurance> data = ctx.Insurance.ToList();
                return View(data);
            }
        }
    }
}