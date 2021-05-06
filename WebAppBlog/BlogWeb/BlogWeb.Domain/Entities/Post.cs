using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogWeb.Domain.Entities
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Title { get; set; }

        [Required]
        [StringLength(maximumLength: 50)]
        public string Website { get; set; }
     
        [Required]
        [StringLength(maximumLength: 700)]
        public string Text { get; set; }
        [Required]
        [StringLength(maximumLength: 100)]
        public string ShortDescription { get; set; }
        [Required]

        [StringLength(maximumLength: 50, ErrorMessage = "Maximum is 50 characters")]
        public string ImagePath { get; set; }
        [Required]
        [DataType("smalldatetime")]
        public DateTime WrittenDate { get; set; }
        [DataType("smalldatetime")]
        public DateTime PublishDate { get; set; }
        public Author Author { get; set; }
        [Required]
        public int AuthorId { get; set; }
        public Category Category { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Archive Archive { get; set; }
        [Required]
        public int ArchiveId { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public Post()
        {
            Tags = new HashSet<Tag>();
            Comments = new HashSet<Comment>();
        }
    }
}
