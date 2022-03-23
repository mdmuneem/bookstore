using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBook.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            // var obj = new { Id = 1, Name = "Nitish" };
            // return View("TempView/Index2.cshtml");
            // return View("../../TempView/Index3");
            return View();
        }
        public ViewResult Aboutus()
        {
            return View("~/TempView/Index2.cshtml");
        }
        public ViewResult Contactus()
        {
            return View();
        }
    }
}
