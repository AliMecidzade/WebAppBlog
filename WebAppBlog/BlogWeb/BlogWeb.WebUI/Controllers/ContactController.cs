using BlogWeb.Domain.Concrete;
using BlogWeb.WebUI.Infrastructure;
using BlogWeb.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BlogWeb.WebUI.Controllers
{
    public class ContactController : Controller
    {

        private BlogWebDbContext _dbContext;


        public ContactController()
        {
            _dbContext = new BlogWebDbContext();
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Send(ContactMessageViewModel model)
        {
            if (ModelState.IsValid)
            {
                 await _dbContext.SendMessageAsync(model);
            }
            return RedirectToAction("Index", "Contact");
        }
    }
}