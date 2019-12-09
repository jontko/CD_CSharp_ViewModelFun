using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModelFun.Models;


namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
    
        [HttpGet("")]
        public IActionResult Index()
        {
            return View ();
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            Number newNumber1 = new Number(){number = 5};
            Number newNumber2 = new Number(){number = 2};
            Number newNumber3 = new Number(){number = 1};
            Number newNumber4 = new Number(){number = 10};
            Number newNumber5 = new Number(){number = 12};
            Number newNumber6 = new Number(){number = 7};

            List<Number> numList = new List<Number>()
            {
                newNumber1,
                newNumber2,
                newNumber3,
                newNumber4,
                newNumber5,
                newNumber6
            };
        return View(numList);
        }


        [HttpGet("users")]
        public IActionResult Users(string FirstName, string LastName)
        {
            List<User> list = new List<User>();
            list.Add(new User { FirstName = "John", LastName = "Smith" });
            list.Add(new User { FirstName = "John", LastName = "Doe" });
            list.Add(new User { FirstName = "John", LastName = "Hancock" });
            list.Add(new User { FirstName = "John", LastName = "Jacobjinglehimerschmitz" });
        return View(list);
        }

        [HttpGet("user")]
        public IActionResult User()
        {
            User user = new User{
            FirstName = "Sally",
            LastName = "Sanderson"
            };
            return View (user);
        }










        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    }
}
