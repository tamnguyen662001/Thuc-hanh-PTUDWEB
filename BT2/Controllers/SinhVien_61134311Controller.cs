
using BT2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BT2.Controllers
{
    public class SinhVien_61134311Controller : Controller
    {
        // GET: SinhVien_61134311
        public ActionResult UseRequest()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UseRequest2(string Mssv, string Ten, double Diem)
        {
            ViewBag.Mssv = Request["Mssv"];
            ViewBag.Ten = Request["Ten"];
            ViewBag.Diem = double.Parse(Request["Diem"]);
            return View();
        }
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