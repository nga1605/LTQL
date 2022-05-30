using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using NTNBaiThucHanh801.Models;
using NTNBaiThucHanh801.Models.Process;

namespace NTNBaiThucHanh801.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        Encrytion encry = new Encrytion();
        LTQLDbContext db = new LTQLDbContext();
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Register(Account acc)
        {
            if (ModelState.IsValid)
            {
                //mã hóa mật khẩu trước khi lưu vào database
                acc.PassWord = encry.PassWordEncrytion(acc.PassWord);
                db.Accounts.Add(acc);
                db.SaveChanges();
                return RedirectToAction("Login", "Account");
            }
            return View(acc);
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login(Account acc)
        {
            if (ModelState.IsValid)
            {
                string encrytionpass = (string)encry.PassWordEncrytion(acc.PassWord);
                var model = db.Accounts.Where(m => m.UserName == acc.UserName && m.PassWord == encrytionpass).ToList().Count();
                //thông tin đăng nhập chính xác
                if (model == 1)
                {
                    FormsAuthentication.SetAuthCookie(acc.UserName, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Thông tin đăng nhập không chính xác");
                }
            }
            return View(acc);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}