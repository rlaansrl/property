using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Property.DataContext;
using Property.Models.User;
using Property.ViewModels;

namespace Property.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository _repository;
        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }
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
                if (_repository.UserLogin(model))
                {
                    HttpContext.Session.SetString("USER_LOGIN_KEY",model.UserId);
                }
                return RedirectToAction("index", "Home");
            }
            ModelState.AddModelError(string.Empty, "아이디 또는 비밀번호가 올바르지 않습니다.");
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
            if (_repository.UserIdCheck(model.UserId) == true)
            {
                ModelState.AddModelError("UserId", "사용할수없는 아이디입니다.");
                return View(model);
            }
            
            if (ModelState.IsValid)
            {
                _repository.AddUser(model);
                return RedirectToAction("Index", "Home");

            }
            return View(model);
        }
        /*public async Task<IActionResult> IdCheck(User model)
        {
            using (var db = new PropertyDbContext())
            {
                var user = db.Users.FirstOrDefault(u=>u.UserId.Equals(model.UserId));
                if (user !=null)
                {
                    ModelState.AddModelError("UserId", "사용할수없는 아이디입니다.");
                }
            }
            return Json("true");
        }*/
        public IActionResult Juso()
        {
            return View();
        }

        public IActionResult jusoPop()
        {
            if (Request.Form["inputYn"].ToString()!=null)
            {

                string a = Request.Form["inputYn"];
            }
            return View();
        }
    }
}