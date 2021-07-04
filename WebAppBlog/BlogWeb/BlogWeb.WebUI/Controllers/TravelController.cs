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
    public class TravelController : Controller
    {
        private BlogWebDbContext _dbContext;
        private int _itemsPerPage;

        public TravelController()
        {
            _dbContext = new BlogWebDbContext();
            _itemsPerPage = 6;
        }
        [HttpGet]
        public async Task<ActionResult> Index(PageModel model) => View(await _dbContext.GetPaginatablePostsAsync(_itemsPerPage, model));

    }
}