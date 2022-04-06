using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BT2.Controllers
{
    public class UseFormCollectionController : Controller
    {
        // GET: UseModel
        public ActionResult UseFormCollection()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UseFormCollection2(FormCollection bien)
        {
            ViewBag.Mssv = bien["Mssv"];
            ViewBag.Ten = bien["Ten"];
            ViewBag.Diem = bien["Diem"];
            return View(ViewBag);
        }
    }
}