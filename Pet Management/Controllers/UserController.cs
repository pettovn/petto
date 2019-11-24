using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pet_Management.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index(String userId)
        {
            return View();
        }
    }
}