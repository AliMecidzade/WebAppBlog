using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWeb.Domain.Entities
{
	public class Archive
	{
		public int Id { get; set; }
		[Required]
		[StringLength(maximumLength: 50)]
		public string Month { get; set; }
		[Required]
		[StringLength(maximumLength: 4)]
		[DataType("char")]
		public string Year { get; set; }
		public ICollection<Post> Posts { get; set; }
		public Archive()
		{
			Posts = new HashSet<Post>();
		}
	}
}
