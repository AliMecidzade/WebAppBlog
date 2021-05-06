using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWeb.Domain.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public User User  { get; set; }
        public int UserId { get; set; }
        [StringLength(maximumLength: 300, ErrorMessage = "Maximum is 300 characters")]
        [Required]
        public string Description { get; set; }
    }
}
