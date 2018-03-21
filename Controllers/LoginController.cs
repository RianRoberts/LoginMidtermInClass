using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginMidTerm.Models;

namespace LoginMidTerm.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult LoginError()
        {
            return View();
        }
           public IActionResult LoginSuccess()
        {
            return View();
        }
    }
}