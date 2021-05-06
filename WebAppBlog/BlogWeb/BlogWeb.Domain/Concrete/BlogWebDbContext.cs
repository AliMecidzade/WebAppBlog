namespace BlogWeb.Domain.Concrete
{
    using BlogWeb.Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BlogWebDbContext : DbContext
    {
      
        public BlogWebDbContext()
            : base("name=BlogWebDbContext")
        {
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Archive> Archives { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<ContactMessage> ContactMessages { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }

    }

}