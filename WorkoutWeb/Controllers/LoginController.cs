using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WorkoutWeb.ViewModel;
using WorkoutWeb.Models.Repository;

namespace WorkoutWeb.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        public ActionResult index(Login_VM model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return View();
        }
        // GET: Login
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Index( Login_VM model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "請輸入帳號密碼。");
                return View(model);
            }

            LoginLogic _user = new LoginLogic();
            

            if (_user.GetT(model) == null)
            {
                ModelState.AddModelError("", "無效的帳號或密碼。");
                return View(model);
            }

            var ticket = new System.Web.Security.FormsAuthenticationTicket(
            version: 1,
            name: _user.User.ToString(), //可以放使用者Id
            issueDate: DateTime.UtcNow,//現在UTC時間
            expiration: DateTime.UtcNow.AddMinutes(30),//Cookie有效時間=現在時間往後+30分鐘
            isPersistent: true,// 是否要記住我 true or false
            userData: _user.Name, //可以放使用者角色名稱
            
            cookiePath: FormsAuthentication.FormsCookiePath);

            var encryptedTicket = FormsAuthentication.Encrypt(ticket); //把驗證的表單加密
            var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            Response.Cookies.Add(cookie);

            //Session["username"] = _user.Name.ToString();

            return RedirectToAction("Index", "Workout");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.RemoveAll();

            return RedirectToAction("Index", "Workout");
        }
    }
}