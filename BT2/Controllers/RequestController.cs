using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BT2.Controllers
{
    public class RequestController : Controller
    {
        //GET: Request
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
       
    }
}