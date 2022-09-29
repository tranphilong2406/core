using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RazorPage.Models;
namespace RazorPage.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index(){
            return View();
        }

        public IActionResult SanPham(){
            SanPham sp = new SanPham();
            sp.TenSanPham = "Rau";
            sp.Gia = 20000;
            sp.MoTa="Day la mo ta cua " + sp.TenSanPham;
            
            return View(sp);
        }

        public IActionResult CyperTech(){
            return View();
        }
    }
}