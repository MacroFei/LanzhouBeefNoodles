using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LanzhouBeefNoodles.controllers
{
    //[Route("[controller]")]
    //[Route("[controller]/[action]")]
    public class HomeController : Controller
    {
       /* public IActionResult Index()
        {
            return View();
        }*/

    
           [Route("[controller]/[action]")]
            public String Index()
            {
                return "Hello from Index";
            }

        public String About()
        {
            return "Hello from About";
        }
        //[Route("[action]")]
        public String Hello1()
        {
            return "Hello 1";
        }
    }
}