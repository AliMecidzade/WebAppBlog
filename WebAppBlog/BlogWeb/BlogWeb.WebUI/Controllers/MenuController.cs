using BlogWeb.Domain.Concrete;
using BlogWeb.WebUI.Infrastructure;
using BlogWeb.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogWeb.WebUI.Controllers
{
    public class MenuController : Controller
    {
        private BlogWebDbContext _dbContext;

        public MenuController()
        {
            _dbContext = new BlogWebDbContext();
        }
        public ActionResult All() => View(_dbContext.GetAllMenus());

    }
}