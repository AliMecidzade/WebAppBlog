using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWeb.WebUI.Models
{
	public class ArchiveViewModel
	{
		public string Month { get; set; }
		public string Year { get; set; }
		public int PostsCount { get; set; }
	}
}