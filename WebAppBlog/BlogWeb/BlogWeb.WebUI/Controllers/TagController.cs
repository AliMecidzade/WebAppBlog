using BlogWeb.Domain.Concrete;
using BlogWeb.WebUI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogWeb.WebUI.Controllers
{
    public class TagController : Controller
    {
        private BlogWebDbContext _dbContext;


        public TagController()
        {
            _dbContext = new BlogWebDbContext();
        }

        [HttpGet]
        public ActionResult All() => View(_dbContext.GetAllTags());
    }
}