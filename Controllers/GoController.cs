using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FreneticLLCWebsite.Controllers
{
    public class GoController : Controller
    {
        public IActionResult Discord()
        {
            return Redirect("https://discord.gg/eggWVJt");
        }
    }
}
