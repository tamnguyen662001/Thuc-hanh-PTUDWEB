using BT2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BT2.Controllers
{
    public class UseModelController : Controller
    {
        // GET: UseModel
        public ActionResult UseModel()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UseModel2(UseFormCollection obj)
        {
            ViewBag.Mssv = obj.MSSV;
            ViewBag.Ten = obj.Ten;
            ViewBag.Diem = obj.Diem;

            return View();
        }
    }
}