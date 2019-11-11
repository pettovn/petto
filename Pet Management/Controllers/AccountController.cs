/************************************************************************
/* Copyright (©) 2019 PETTO SYSTEM
/************************************************************************
/* File Name    : AccountController.cs
/* Function     : Account controller
/* Create       : LinhTran 2019/11/11
/************************************************************************/
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Pet_Management.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        #region Login
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// Login Function
        /// </summary>
        /// <param name="user_login">email or phone number</param>
        /// <param name="password">password</param>
        /// <returns>IActionResult</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(string user_login, string password)
        {
            _logger.LogInformation("User login");


            return View();
        }
        #endregion

        #region Register
        public IActionResult Register()
        {
            return View();
        }
        #endregion

        #region ForgotPassword
        public IActionResult ForgotPassword()
        {
            return View();
        }
        #endregion
    }
}