using BlogWeb.Domain.Concrete;
using BlogWeb.Domain.Entities;
using System;
using BlogWeb.WebUI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWeb.WebUI.Infrastructure
{
  public static class DbContextExtensions
    {
    public static IEnumerable<CategoryViewModel> GetAllCategories(this BlogWebDbContext _dbContext)
        {
            return _dbContext.Categories.Select(x => new CategoryViewModel
            { 
                Name = x.Name,
                PostsCount = x.Posts.Count()
            });
        }

    }
}
