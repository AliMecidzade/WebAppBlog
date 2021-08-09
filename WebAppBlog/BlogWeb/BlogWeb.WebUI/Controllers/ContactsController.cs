using BlogWeb.Domain.Concrete;
using BlogWeb.WebUI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace BlogWeb.WebUI.Controllers
{
    public class ContactsController : Controller
    {

        private BlogWebDbContext _dbContext;

        public ContactsController()
        {
            _dbContext = new BlogWebDbContext();
        }
        // GET: Contacts
        
        [ActionName("Index")]
        public async Task<ActionResult> Index() => View(await _dbContext.GetAllContactMessagesAsync());



        // GET: Contacts/Delete/5
        [ActionName("Delete")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
           await _dbContext.RemoveContactMessageAsync(id);


            return RedirectToAction("Index");
         }
    
    }
}
