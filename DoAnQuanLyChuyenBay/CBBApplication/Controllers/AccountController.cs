using CBBApplication.Models;
using DoAnCB.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CBBApplication.Controllers
{
    [Route("Account")]

    public class AccountController : BaseController
    {
        [AllowAnonymous]
        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUser createUser)
        {
            var createUserResult = await PostRequest("account/createUser", createUser);
            string token = createUserResult.data;
            string message = createUserResult.message;
            if (token != null)
            {
                HttpContext.Session.SetString("UserToken", token);
                return RedirectToAction("Login", "Account");
            }
            else
            {
                TempData["loginError"] = message;
                return RedirectToAction("CreateUser", "Account");
            }



        }


        [HttpPost]
        [AllowAnonymous]
        [Route("LoginAction")]
        public async Task<ActionResult> LoginAction(AccountLoginModel model)
        {
            var loginResult = await PostRequest("account/login", model);
            string token = loginResult.data;
            string message = loginResult.message;
            if (token != null)
            {
                HttpContext.Session.SetComplexData("UserToken", token);
                return RedirectToAction("Index", "QuanLyDanhSachChuyenBay");
            }
            else
            {
                TempData["loginError"] = message;
                return RedirectToAction("Login", "Account");
            }
            
        }

    }
}
