using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWeb.WebUI.Models
{
	public class PostDetailsViewModel
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string ShortDescription { get; set; }
		public string Text { get; set; }
		public string ImagePath { get; set; }
		public int ViewsCount { get; set; }
		public AuthorViewModel Author { get; set; }
		public string CategoryName { get; set; }
		public IEnumerable<CommentViewModel> Comments { get; set; }
		public IEnumerable<TagViewModel> Tags { get; set; }
	}
}