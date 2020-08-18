using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wristband.Models;

namespace Wristband.Controllers
{
    public class WristModelController : Controller
    {
        WristbandModel data = new WristbandModel();
        public IActionResult Index()
        {
             
            var lstColors = new List<string>() { "red", "yellow" ,  "black", "white", "green", "pink" };
            data.colors = lstColors;
 
            var lstfrmimg = new List<string>() { "pat1.jpg", "pat2.jpg", "pat3.jpg" };
            data. frmimg = lstfrmimg;

           
             
            return View(data);
           
        }
    }
}
