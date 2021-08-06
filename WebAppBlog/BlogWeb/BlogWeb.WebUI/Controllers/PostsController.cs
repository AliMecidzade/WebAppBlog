using BlogWeb.Domain.Concrete;
using BlogWeb.Domain.Entities;
using BlogWeb.WebUI.Infrastructure;
using BlogWeb.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BlogWeb.WebUI.Controllers
{
    public class PostsController : Controller
    {
        private BlogWebDbContext _dbContext;

        public PostsController()
        {
            _dbContext = new BlogWebDbContext();
        }
        [HttpGet]
        [ActionName("Index")]
        public async Task<ActionResult> Index() => View(await _dbContext.GetAllPostsAsync());

        // GET: Posts/Details/5
        [HttpGet]
        [ActionName("Index")]
        public async Task<ActionResult> DetailsAsync(int id) => View(await _dbContext.GetSinglePostDetailsAsync(id));


        // GET: Posts/Create
        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create() => View("Edit", new PostEditModel());
       
        // POST: Posts/Create
        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Posts/Edit/5
        [HttpGet]
        [ActionName("Edit")]
        public async Task<ActionResult> EditAsync(int id) => View(await _dbContext.GetPostEditModelAsync(id));


        // POST: Posts/Edit/5
        [HttpPost]
        [ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(PostEditModel model, HttpPostedFileBase image = null)
        {
            if (ModelState.IsValid)
            {
                if(image != null)
                {
                    model.ImageMimeType = image.ContentType;
                    model.ImageData = new byte[image.ContentLength];
                  
                    model.WrittenDate = DateTime.Now;
                    model.ShortDescription = model.Text.Substring(0, 100);
                    model.AuthorId = Convert.ToInt32(Session["user"]);
                    image.InputStream.Read(model.ImageData, 0, image.ContentLength);
                }
                await _dbContext.SavePostAsync(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
                
            
        }

        // GET: Posts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Posts/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public async Task<FileContentResult> GetImage(int id)
        {
            Post post = await _dbContext.GetPostAsync(id);

            if (post != null)
                return File(post.ImageData, post.ImageMimeType);
            else
                return null;

        }
    }
}
