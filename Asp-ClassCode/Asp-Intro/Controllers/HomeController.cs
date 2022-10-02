using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Intro.Controllers
{
    public class HomeController : Controller
    {
        //public string Index(int id, string name)
        //{
        //    return "Home Page" + "-" + id + "-" + name;
        //}

        //public IActionResult Index(int id, string name)
        //{
        //    return Json(new { name = "Seid", surname = "Nuraliyev" });
        //}

        //public IActionResult Index(int id, string name)
        //{
        //    return Content(9.ToString());
        //}

        public IActionResult Index()
        {
            return View();
        }

        //public string FullData(string name,string surname,int age)
        //{
        //    return $"Name-{name}: Surname-{surname}: Age-{age}";
        //}
    }
}
