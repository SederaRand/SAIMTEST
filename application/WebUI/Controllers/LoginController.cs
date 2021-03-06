using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SAIM_FO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SAIM_FO.Controllers
{
    public class LoginController : Controller
    {
        private IUserService _userService;

        public LoginController(IUserService userService)
        {
            this._userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            string username = user.Username;
            string password = user.Password;

            bool checkResult = _userService.Login(username, password);
            
            if (checkResult == true)
            {
                // Return Index Home application 
                return RedirectToAction("Index", "Company");            
            }
            else
            {
                // Return span to nofity that username or password are wrong
                ViewBag.Error = "Votre identifiant ou mot de passe est incorrecte";
                return View("Index");                
            }
        }
    }
}
