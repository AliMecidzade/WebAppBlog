using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogWeb.WebUI.Models
{
	public class PostEditModel
	{
		public int Id { get; set; }

		[Required]
		[StringLength(maximumLength: 300)]
		public string Title { get; set; }
	
		[StringLength(maximumLength: 500)]
		public string ShortDescription { get; set; }
		[Required]
		[StringLength(maximumLength: 5000)]
		public string Text { get; set; }
		[Required]
		public byte[] ImageData { get; set; }
		[Required]
		public string ImageMimeType { get; set; }
	
		public DateTime WrittenDate { get; set; }


        public AuthorViewModel Author { get; set; }
        [Required]
		public int AuthorId { get; set; }
		[Required]
		public string CategoryName { get; set; }
		public int CategoryId { get; set; }
		public IEnumerable<SelectListItem> Categories { get; set; }

		public PostEditModel()
		{
			Categories = new BlogWeb.Domain.Concrete.BlogWebDbContext().Categories.Select(x => new SelectListItem
			{
				Text = x.Name,
				Disabled = false,
				Value = x.Name,
				Selected = true
			});
		}

        public PostEditModel(int id , string text, string category, string title , string shortDescription)
        {
			Id = id;
			ShortDescription = shortDescription;
			Text = text;
			CategoryName = category;
			Title = title;

			Categories = new BlogWeb.Domain.Concrete.BlogWebDbContext().Categories.Select(x => new SelectListItem
			{
				Text = x.Name,
				Disabled = false,
				Value = x.Name,
				Selected = true
			});

		}

	}
}