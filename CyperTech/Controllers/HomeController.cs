using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CyperTech.Controllers
{
    public class HomeController : Controller{
        public IActionResult Index(){
            return View();
        }

        public IActionResult Contact(){
            return View();
        }

        public IActionResult Error404(){
            return View("404");
        }
    }
}