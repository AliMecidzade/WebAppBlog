using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWeb.Domain.Entities
{
	public class Tag
	{
		public int Id { get; set; }
		[Required]
		[StringLength(maximumLength: 50)]
		public string Name { get; set; }
		public ICollection<Post> Posts { get; set; }
		public Tag()
		{
			Posts = new HashSet<Post>();
		}
	}
}

