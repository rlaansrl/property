using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Property.DataContext;
using Property.Models;
using Property.ViewModels;

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
        /// 로그인 post
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new PropertyDbContext())
                {
                    var user = db.Users.FirstOrDefault(u=>u.UserId.Equals(model.UserId)
                                                        &&u.UserPw.Equals(model.UserPw));
                    if (user !=null)
                    {
                        //로그인 성공
                        HttpContext.Session.SetInt32("USER_LOGIN_KEY", user.UserNo);
                        return RedirectToAction("Index", "Home");
                    }
                }
                ModelState.AddModelError(string.Empty,"아이디 또는 비밀번호가 올바르지 않습니다.");
            }
            return View(model);
        }

        /// <summary>
        /// 로그아웃
        /// </summary>
        /// <returns></returns>
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("USER_LOGIN_KEY");
            return RedirectToAction("Index","Home");
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
                    model.UserInsertDate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-mm-dd HH:mm:ss"));
                    db.Users.Add(model);
                    db.SaveChanges();
                }
                return RedirectToAction("Index", "Home");

            }
            return View(model);
        }
    }
}