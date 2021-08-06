using BlogWeb.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWeb.WebUI.Areas.Admin.Models
{
    public class PostReportViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string CategoryName { get; set; }
        public int ViewsCount{ get; set; }
        public DateTime WrittenDate { get; set; }
        public DateTime PublishedDate { get; set; }
        public int CommentsCount { get; set; }
        public AuthorViewModel Author { get; set; }



    }
}