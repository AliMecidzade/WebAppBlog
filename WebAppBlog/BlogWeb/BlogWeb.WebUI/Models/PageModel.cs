using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWeb.WebUI.Models
{
	public class PageModel
	{
		public int Number { get; set; } = 1;
		public int PagesCount { get; set; } = 1;
		public string Action { get; set; }
		public string Controller { get; set; }
	}

															
}