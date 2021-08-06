using BlogWeb.Domain.Concrete;
using BlogWeb.WebUI.Areas.Admin.Filters;
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
    public class DashboardController : Controller
    {

        private BlogWebDbContext _dbContext;


        public DashboardController()
        {
            _dbContext = new BlogWebDbContext();
        }
        [HttpGet]
        [AuthorizeFilter("/Admin/Account/Login", "user")]
        public async Task<ActionResult> Index() => View(await _dbContext.GetEntitiesCountAsync());
   
        
            // user, authors , posts, comments, contact messages, categories , archives
        

           
        
    }
}