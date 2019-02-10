using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Property.DataContext;
using Property.Models;

namespace Property.Controllers
{
    public class UserController : Controller
    {
        /// <summary>
        /// 로그인 190210
        /// </summary>
        /// <returns></returns>
        public IActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// 회원가입 190210
        /// </summary>
        /// <returns></returns>
        public IActionResult Register()
        {
          
            return View();
        }

        /// <summary>
        /// 회원가입 post
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost] 
        public IActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new PropertyDbContext())
                {
                    db.Users.Add(model);
                    db.SaveChanges();
                }
                return RedirectToAction("Index", "Home");

            }
            return View(model);
        }
    }
}