using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BT2.Controllers
{
    public class UseActionController : Controller
    {
        // GET: UseAction
        public ActionResult UseAction()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UseAction2(string Mssv, string Ten, double Diem)
        {
            ViewBag.Mssv = Mssv;
            ViewBag.Ten = Ten;
            ViewBag.Diem = Diem;

            return View();
        }
       
    }
}