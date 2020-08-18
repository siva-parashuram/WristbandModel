using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wristband.Models;

namespace Wristband.Controllers
{
    public class WristbandController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
