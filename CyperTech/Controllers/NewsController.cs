using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CyperTech.Controllers{
    public class NewsController : Controller{
        public IActionResult Detail(){
            return View();
        }
    }
}