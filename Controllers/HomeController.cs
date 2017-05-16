using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FreneticForum.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult ErrorInternal()
        {
            return View();
        }

        public IActionResult Error404()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BusinessLog()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        
        public IActionResult Policy()
        {
            return View();
        }
        
        public IActionResult SOPS()
        {
            return View();
        }
    }
}
