using BlogWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWeb.WebUI.Areas.Admin.Models
{
    public class CategoryReportViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}