using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWeb.WebUI.Models
{
	public class PostViewModel
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string ShortDescription { get; set; }
		public string ImagePath { get; set; }
		public DateTime WrittenDate { get; set; }
		public string CategoryName { get; set; }
		public int CommentsCount { get; set; }
	}
}