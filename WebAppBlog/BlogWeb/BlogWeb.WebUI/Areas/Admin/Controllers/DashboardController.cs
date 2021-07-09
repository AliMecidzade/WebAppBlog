using BlogWeb.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogWeb.WebUI.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {

        private BlogWebDbContext _dbContext;


        public DashboardController()
        {
            _dbContext = new BlogWebDbContext();
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}