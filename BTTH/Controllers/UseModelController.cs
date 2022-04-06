using BTTH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTTH.Controllers
{
    public class UseModelController : Controller
    {
        public ActionResult UseModel()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UseModel(UseModel cal)
        {
            switch (cal.pt)
            {
                case "+": ViewBag.KQ = cal.a + cal.b; break;
                case "-": ViewBag.KQ = cal.a - cal.b; break;
                case "*": ViewBag.KQ = cal.a * cal.b; break;
                case "/":
                    if (cal.b == 0) ViewBag.KQ = "Không chia được cho 0";
                    else ViewBag.KQ = cal.a / cal.b; break;
            }
            return View();
        }
    }
}