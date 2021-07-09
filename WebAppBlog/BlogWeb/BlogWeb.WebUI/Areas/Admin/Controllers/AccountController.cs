using BlogWeb.Domain.Concrete;
using BlogWeb.Domain.Entities;
using BlogWeb.WebUI.Areas.Admin.Models;
using BlogWeb.WebUI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BlogWeb.WebUI.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        private BlogWebDbContext _dbContext;


        public AccountController()
        {
            _dbContext = new BlogWebDbContext();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginModel model)
        {
            User user = null;
            if (ModelState.IsValid)
            {
             user = await _dbContext.GetUserAsync(model);
            }

            if (user == null) 
            {

                ModelState.AddModelError("", "Email or Password is wrong! Try again!");
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Dashboard");
            }
            
        }
    }
}