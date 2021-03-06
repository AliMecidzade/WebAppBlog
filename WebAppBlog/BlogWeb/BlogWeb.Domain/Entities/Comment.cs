using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWeb.Domain.Entities
{
	public class Comment
	{
		public int Id { get; set; }
		[Required]
		[StringLength(maximumLength: 90)]
		public string Username { get; set; }
		[Required]
		
		[StringLength(maximumLength: 90)]
		public string Website { get; set; }
		[Required]
		[EmailAddress]
		[StringLength(maximumLength: 80, ErrorMessage = "Maximum is 50 characters!")]
		public string Email { get; set; }
		[Required]
		[StringLength(maximumLength: 900)]
		public string Message { get; set; }
		[Required]
		[DataType("smalldatetime")]
		public DateTime SubmmittedDate { get; set; }
		public User User { get; set; }
		[Required]
		public int UserId { get; set; }
		public Post Post { get; set; }
		[Required]
		public int PostId { get; set; }
	}
}

