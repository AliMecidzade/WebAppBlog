using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWeb.WebUI.Models
{
	public class PopularPostViewModel
	{
        public int Id { get; set; }
        public string Title { get; set; }
		public DateTime PublishDate { get; set; }
		public string AuthorName { get; set; }
		public int CommentsCount { get; set; }
		public byte[] ImageData { get; set; }

		public string ImageMimeType { get; set; }
	}
}