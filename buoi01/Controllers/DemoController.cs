using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace buoi01.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Chuoi()
        {
            
            string a = string.Empty;
            return "hello";
        }

        public int So()
        {
            return new Random().Next(1000, 10000);
        }

        public IActionResult TuDien()
        {
            return View();
        }
    }
}