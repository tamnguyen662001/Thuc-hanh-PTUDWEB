using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTTH.Controllers
{
    public class UseActionController : Controller
    {
        // GET: UseAction
        public ActionResult UseArguments()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UseArguments(double a, double b, string pt = "+")
        {
            switch (pt)
            {
                case "+": ViewBag.KQ = a + b; break;
                case "-": ViewBag.KQ = a - b; break;
                case "*": ViewBag.KQ = a * b; break;
                case "/":
                    if (b == 0) ViewBag.KQ = "Không chia được cho 0";
                    else ViewBag.KQ = a / b; break;
            }
            return View();
        }
    }
}