using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWeb.Domain.Entities
{
	public class Menu
	{
		public int Id { get; set; }
		[Required]
		[StringLength(maximumLength: 50)]
		public string Name { get; set; }
		[Required]
		[StringLength(maximumLength: 50)]
		public string Controller { get; set; }
		[Required]
		[StringLength(maximumLength: 50)]
		public string Action { get; set; }
		[Required]
		public bool IsActive { get; set; }
	}
}
