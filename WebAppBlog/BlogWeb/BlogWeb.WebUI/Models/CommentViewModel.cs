using BlogWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWeb.WebUI.Models
{
	public class CommentViewModel
	{
		public string Username { get; set; }
		public string Message { get; set; }
		public DateTime SubmmittedDate { get; set; }
		public User User { get; set; }
	}
}