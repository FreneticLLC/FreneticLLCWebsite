using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FreneticLLCWebsite.Controllers
{
    public class GiggleController : Controller
    {
        public IActionResult Experiment()
        {
            return View();
        }
    }
}
