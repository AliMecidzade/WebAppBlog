using BlogWeb.Domain.Concrete;
using BlogWeb.WebUI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BlogWeb.WebUI.Controllers
{
    public class PostController : Controller
    {
        private BlogWebDbContext _dbContext;

        public PostController()
        {
            _dbContext = new BlogWebDbContext();
        }
        public ActionResult AllPopular()
        {
            return View(_dbContext.GetPopularPosts());
        }
        [HttpGet]
        public async Task<ActionResult> Details(int id) => View(await _dbContext.GetSinglePostDetailsAsync(id));

    }
}