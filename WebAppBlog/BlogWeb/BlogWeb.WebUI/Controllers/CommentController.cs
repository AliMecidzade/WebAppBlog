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
    public class CommentController : Controller
    {
        private BlogWebDbContext _dbContext;


        public CommentController()
        {
            _dbContext = new BlogWebDbContext();
        }
        [HttpGet]
        public ActionResult Form(CommentPostModel model)
        {
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  async Task<ActionResult> Add(CommentPostModel model)
        {
            if (ModelState.IsValid)
            {
                await _dbContext.AddCommentAsync(model);
            }
            return RedirectToAction("Detsils", "Post" , routeValues: new { id = model.PostId});
        }
       
    }
}