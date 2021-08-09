using BlogWeb.Domain.Concrete;
using BlogWeb.WebUI.Areas.Admin.Models;
using BlogWeb.WebUI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BlogWeb.WebUI.Controllers
{
    public class CategoriesController : Controller
    {
        private BlogWebDbContext _dbContext;

        // GET: Categories
        public CategoriesController()
        {
            _dbContext = new BlogWebDbContext();
        }


        [ActionName("Index")]
        public async Task<ActionResult> Index() => View(await _dbContext.GetAllCategoriesAsync());

        // GET: Categories/Details/5

        // GET: Categories/Create
        [ActionName("Create")]
        public async Task<ActionResult> CreateAsync(CategoryCreateModel model) => View(await _dbContext.AddCategoryAsync(model));
       

        // GET: Categories/Delete/5

        [ActionName("Delete")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            await _dbContext.RemoveCategoryAsync(id);

            return RedirectToAction("Index");
        }

    }
}
