using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWeb.WebUI.Areas.Admin.Models
{
    public class ContactMessageReportViewModel
    {
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }	
		public string Subject { get; set; }
		public string Message { get; set; }
		public DateTime SubmittedDate { get; set; }
		public DateTime WrittenDate { get; set; }
	}
}