using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using view.Models;

namespace view.Controllers
{
    public class HomeController : Controller
    {




        [HttpGet("show")]
        public IActionResult NewToon()
        {  

            return View();
        }

        [HttpPost("create")]
        public IActionResult CreateUser(cartoon x)
        {
            if(ModelState.IsValid)
            {
                // do somethng!  maybe insert into db?  then we will redirect
                return RedirectToAction("ShowUser", x);
            }
            else
            {
                return View("NewToon");
            }

        }


        [HttpGet("Toons")]
        public IActionResult ShowUser(cartoon x)
        {
        
            return View("toon", x);
        }


        [HttpGet("numbers")]
        public IActionResult ShowNumbers()
        {
                // Numbers x = new  Numbers()
            {
                int[] numbers = {1,2,3,4,5,6,7};
                    


                return View("number", numbers);
            }
        }


        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            User x = new  User()
            {
                FirstName = "kian",
                LastName ="Chachi"
            };

            return View("UserDetail", x);
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
