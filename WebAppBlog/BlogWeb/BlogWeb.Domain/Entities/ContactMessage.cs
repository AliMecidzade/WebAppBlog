using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWeb.Domain.Entities
{
	public class ContactMessage
	{
		public int Id { get; set; }
		[Required]
		[StringLength(maximumLength: 50)]
		public string Name { get; set; }
		[Required]
		[EmailAddress]
		[StringLength(maximumLength: 40, ErrorMessage = "Maximum is 50 characters!")]
		public string Email { get; set; }
		[Required]
		[StringLength(maximumLength: 500)]
		public string Message { get; set; }
		[Required]
		[DataType("smalldatetime")]
		public DateTime SubmmittedDate { get; set; }
	}
}

