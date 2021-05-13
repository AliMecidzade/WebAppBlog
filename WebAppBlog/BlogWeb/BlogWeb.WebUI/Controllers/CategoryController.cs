using BlogWeb.Domain.Concrete;
using BlogWeb.WebUI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogWeb.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private BlogWebDbContext _dbContext;
        public CategoryController()
        {
            _dbContext = new BlogWebDbContext();

        }
        public ActionResult All() => View(_dbContext.GetAllCategories());







    }
}