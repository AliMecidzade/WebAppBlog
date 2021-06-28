using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWeb.WebUI.Models
{
	public class PopularPostViewModel
	{
		public string Title { get; set; }
		public DateTime PublishDate { get; set; }
		public string AuthorName { get; set; }
		public int CommentsCount { get; set; }
		public string ImagePath { get; set; }
	}
}