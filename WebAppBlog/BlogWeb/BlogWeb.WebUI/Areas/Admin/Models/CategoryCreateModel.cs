using BlogWeb.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogWeb.WebUI.Areas.Admin.Models
{
    public class CategoryCreateModel
    {
        public int Id { get; set; }
        [Required]
		[StringLength(maximumLength: 50)]
		public string Name { get; set; }

	}
}