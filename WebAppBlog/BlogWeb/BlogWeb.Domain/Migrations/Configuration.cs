namespace BlogWeb.Domain.Migrations
{
    using BlogWeb.Domain.Entities;
    using System;
    using System.Configuration;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BlogWeb.Domain.Concrete.BlogWebDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(BlogWeb.Domain.Concrete.BlogWebDbContext context)
        {
            #region 
            context.Menus.AddOrUpdate(new Menu
            {
                Id = 1,
                Name = "Fashion",
                Action = "Index",
                Controller = "Fashion",
                IsActive = true
            },
            new Menu
            {
                Id = 2,
                Name = "Travel",
                Action = "Index",
                Controller = "Travel",
                IsActive = true
            },
            new Menu
            {
                Id = 4,
                Name = "About",
                Action = "Index",
                Controller = "About",
                IsActive = true
            },
            new Menu
            {
                Id = 3,
                Name = "Contact",
                Action = "Index",
                Controller = "Contact",
                IsActive = true
            }
            );
            context.Categories.AddOrUpdate(new Category
            {
                Id = 1,
                Name = "Fashion"
            },
            new Category
            {
                Id = 2,
                Name = "Technology"
            },
            new Category
            {
                Id = 3,
                Name = "Travel"
            },
            new Category
            {
                Id = 4,
                Name = "Food"
            },
            new Category
            {
                Id = 5,
                Name = "Photography"
            }
            );

            context.Tags.AddOrUpdate(new Tag
            {
                Id = 1,
                Name = "Animals"
            },
            new Tag
            {
                Id = 2,
                Name = "Human"
            },
            new Tag
            {
                Id = 3,
                Name = "People"
            },
            new Tag
            {
                Id = 4,
                Name = "Cat"
            },
            new Tag
            {
                Id = 5,
                Name = "Dog"
            },
            new Tag
            {
                Id = 6,
                Name = "Nature"
            },
            new Tag
            {
                Id = 7,
                Name = "Leaves"
            },
            new Tag
            {
                Id = 8,
                Name = "Food"
            }
            );

            var tag1 = new Tag { Id = 1, Name = "Cat" };
            var tag2 = new Tag { Id = 2, Name = "Human" };
            var tag3 = new Tag { Id = 3, Name = "People" };
            var tag4 = new Tag { Id = 4, Name = "Cat" };
            var tag5 = new Tag { Id = 5, Name = "Dog" };
            var tag6 = new Tag { Id = 6, Name = "Nature" };
            var tag7 = new Tag { Id = 7, Name = "Leaves" };
            var tag8 = new Tag { Id = 8, Name = "Food" };
            context.Tags.AddOrUpdate(tag1, tag2, tag3, tag4, tag5, tag6, tag7, tag8);

            context.Archives.AddOrUpdate(new Archive
            {
                Id = 8,
                Month = "December",
                Year = "2018"
            },
            new Archive
            {
                Id = 2,
                Month = "September",
                Year = "2018"
            },
            new Archive
            {
                Id = 3,
                Month = "August",
                Year = "2018"
            },
            new Archive
            {
                Id = 4,
                Month = "July",
                Year = "2018"
            },
            new Archive
            {
                Id = 5,
                Month = "June",
                Year = "2018"
            },
            new Archive
            {
                Id = 6,
                Month = "May",
                Year = "2018"
            }
            );

            context.Users.AddOrUpdate(new User
            {
                Id = 1,
                IsAuthor = true,
                Email = ConfigurationManager.AppSettings["email"],
                Password = ConfigurationManager.AppSettings["password"],
                Username = "John Smith",
                ImagePath = "person_1.png"
            }
            );

            context.Authors.AddOrUpdate(new Author
            {
                Id = 1,
                UserId = 1,
                Description = "John Smith (baptized 6 January 1580 – 21 June 1631) was an English soldier, explorer, colonial governor, Admiral of New England, and author. He played an important role in the establishment of the colony at Jamestown"
            });
            #endregion

            /*  var post1 = new Post
              {
                  Id = 1,
                  Title = "A Loving Heart is the Truest Wisdom",
                  ImagePath = "image_1.jpg",
                  Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis, eius " +
                      "mollitia suscipit, quisquam doloremque distinctio perferendis et doloribus unde architecto optio " +
                      "laboriosam porro adipisci sapiente officiis nemo accusamus ad praesentium? Esse minima nisi et. " +
                      "Dolore perferendis, enim praesentium omnis, iste doloremque quia officia optio deserunt molestiae " +
                      "voluptates soluta architecto tempora.",
                  ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                  ArchiveId = 2,
                  CategoryId = 4,
                  AuthorId = 1,
                  WrittenDate = DateTime.Now,
                  PublishDate = DateTime.Now,
                  ViewsCount = 3
              };*/
            /*     using (
                      var transaction = context.Database.BeginTransaction())
                 {
                     try
                     {
                         context.Tags.AddOrUpdate(tag1, tag2, tag3, tag4, tag5, tag6, tag7, tag8);
                         context.Posts.AddOrUpdate(post1);

                         post1.Tags.Add(tag1);
                         post1.Tags.Add(tag2);
                         post1.Tags.Add(tag5);

                         tag1.Posts.Add(post1);
                         tag2.Posts.Add(post1);
                         tag5.Posts.Add(post1);
                     }
                     catch
                     {

                         transaction.Rollback();
                     }
                 }*/



            #region
          /*  context.Posts.AddOrUpdate(

                    new Post
                    {

                        Id = 2,
                        Title = "Great Things Never Came from Comfort Zone",
                        ImagePath = "image_2.jpg",
                        Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis, eius ",

                        ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                        ArchiveId = 2,
                        CategoryId = 1,
                        AuthorId = 1,
                        WrittenDate = DateTime.Now,
                        PublishDate = DateTime.Now,
                        ViewsCount = 11
                    },
             new Post
             {
                 Id = 3,
                 Title = "Paths Are Made by Walking",
                 ImagePath = "image_3.jpg",
                 Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis, eius " +
                "mollitia suscipit, quisquam doloremque distinctio perferendis et doloribus unde architecto optio " +
                "laboriosam porro adipisci sapiente officiis nemo accusamus ad praesentium? Esse minima nisi et. " +
                "Dolore perferendis, enim praesentium omnis, iste doloremque quia officia optio deserunt molestiae " +
                "voluptates soluta architecto tempora.",
                 ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                 ArchiveId = 3,
                 CategoryId = 4,
                 AuthorId = 1,
                 WrittenDate = DateTime.Now,
                 PublishDate = DateTime.Now,
                 ViewsCount = 3
             },
            new Post
            {
                Id = 4,
                Title = "The Secret of Getting Ahead is Getting Started",
                ImagePath = "image_4.jpg",
                Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis, eius " +
                "mollitia suscipit, quisquam doloremque distinctio perferendis et doloribus unde architecto optio " +
                "laboriosam porro adipisci sapiente officiis nemo accusamus ad praesentium? Esse minima nisi et. " +
                "Dolore perferendis, enim praesentium omnis, iste doloremque quia officia optio deserunt molestiae " +
                "voluptates soluta architecto tempora.",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                ArchiveId = 4,
                CategoryId = 4,
                AuthorId = 1,
                WrittenDate = DateTime.Now,
                PublishDate = DateTime.Now,
                ViewsCount = 3
            },
            new Post
            {
                Id = 5,
                Title = "You Can't Blame Gravity for Falling in Love",
                ImagePath = "image_5.jpg",
                Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis, eius " +
                "mollitia suscipit, quisquam doloremque distinctio perferendis et doloribus unde architecto optio " +
                "laboriosam porro adipisci sapiente officiis nemo accusamus ad praesentium? Esse minima nisi et. " +
                "Dolore perferendis, enim praesentium omnis, iste doloremque quia officia optio deserunt molestiae " +
                "voluptates soluta architecto tempora.",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                ArchiveId = 5,
                CategoryId = 3,
                AuthorId = 1,
                WrittenDate = DateTime.Now,
                PublishDate = DateTime.Now,
                ViewsCount = 10
            },
            new Post
            {
                Id = 6,
                Title = "Great Things Never Came from Comfort Zone",
                ImagePath = "image_6.jpg",
                Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis, eius " +
                "mollitia suscipit, quisquam doloremque distinctio perferendis et doloribus unde architecto optio " +
                "laboriosam porro adipisci sapiente officiis nemo accusamus ad praesentium? Esse minima nisi et. " +
                "Dolore perferendis, enim praesentium omnis, iste doloremque quia officia optio deserunt molestiae " +
                "voluptates soluta architecto tempora.",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                ArchiveId = 6,
                CategoryId = 2,
                AuthorId = 1,
                WrittenDate = DateTime.Now,
                PublishDate = DateTime.Now,
                ViewsCount = 5
            },
            new Post
            {
                Id = 7,
                Title = "A Loving Heart is the Truest Wisdom",
                ImagePath = "image_7.jpg",
                Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis, eius " +
                "mollitia suscipit, quisquam doloremque distinctio perferendis et doloribus unde architecto optio " +
                "laboriosam porro adipisci sapiente officiis nemo accusamus ad praesentium? Esse minima nisi et. " +
                "Dolore perferendis, enim praesentium omnis, iste doloremque quia officia optio deserunt molestiae " +
                "voluptates soluta architecto tempora.",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                ArchiveId = 6,
                CategoryId = 4,
                AuthorId = 1,
                WrittenDate = DateTime.Now,
                PublishDate = DateTime.Now,
                ViewsCount = 3
            },
            new Post
            {
                Id = 8,
                Title = "Great Things Never Came from Comfort Zone",
                ImagePath = "image_8.jpg",
                Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis, eius " +
                "mollitia suscipit, quisquam doloremque distinctio perferendis et doloribus unde architecto optio " +
                "laboriosam porro adipisci sapiente officiis nemo accusamus ad praesentium? Esse minima nisi et. " +
                "Dolore perferendis, enim praesentium omnis, iste doloremque quia officia optio deserunt molestiae " +
                "voluptates soluta architecto tempora.",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                ArchiveId = 8,
                CategoryId = 3,
                AuthorId = 1,
                WrittenDate = DateTime.Now,
                PublishDate = DateTime.Now,
                ViewsCount = 12
            },
            new Post
            {
                Id = 9,
                Title = "Paths Are Made by Walking",
                ImagePath = "image_9.jpg",
                Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis, eius " +
                "mollitia suscipit, quisquam doloremque distinctio perferendis et doloribus unde architecto optio " +
                "laboriosam porro adipisci sapiente officiis nemo accusamus ad praesentium? Esse minima nisi et. " +
                "Dolore perferendis, enim praesentium omnis, iste doloremque quia officia optio deserunt molestiae " +
                "voluptates soluta architecto tempora.",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                ArchiveId = 2,
                CategoryId = 4,
                AuthorId = 1,
                WrittenDate = DateTime.Now,
                PublishDate = DateTime.Now,
                ViewsCount = 3
            },
            new Post
            {
                Id = 10,
                Title = "The Secret of Getting Ahead is Getting Started",
                ImagePath = "image_10.jpg",
                Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis, eius " +
                "mollitia suscipit, quisquam doloremque distinctio perferendis et doloribus unde architecto optio " +
                "laboriosam porro adipisci sapiente officiis nemo accusamus ad praesentium? Esse minima nisi et. " +
                "Dolore perferendis, enim praesentium omnis, iste doloremque quia officia optio deserunt molestiae " +
                "voluptates soluta architecto tempora.",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                ArchiveId = 3,
                CategoryId = 4,
                AuthorId = 1,
                WrittenDate = DateTime.Now,
                PublishDate = DateTime.Now,
                ViewsCount = 3
            },
            new Post
            {
                Id = 11,
                Title = "You Can't Blame Gravity for Falling in Love",
                ImagePath = "image_11.jpg",
                Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis, eius " +
                "mollitia suscipit, quisquam doloremque distinctio perferendis et doloribus unde architecto optio " +
                "laboriosam porro adipisci sapiente officiis nemo accusamus ad praesentium? Esse minima nisi et. " +
                "Dolore perferendis, enim praesentium omnis, iste doloremque quia officia optio deserunt molestiae " +
                "voluptates soluta architecto tempora.",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                ArchiveId = 4,
                CategoryId = 3,
                AuthorId = 1,
                WrittenDate = DateTime.Now,
                PublishDate = DateTime.Now,
                ViewsCount = 10
            },
            new Post
            {
                Id = 12,
                Title = "Great Things Never Came from Comfort Zone",
                ImagePath = "image_12.jpg",
                Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis, eius " +
                "mollitia suscipit, quisquam doloremque distinctio perferendis et doloribus unde architecto optio " +
                "laboriosam porro adipisci sapiente officiis nemo accusamus ad praesentium? Esse minima nisi et. " +
                "Dolore perferendis, enim praesentium omnis, iste doloremque quia officia optio deserunt molestiae " +
                "voluptates soluta architecto tempora.",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                ArchiveId = 5,
                CategoryId = 2,
                AuthorId = 1,
                WrittenDate = DateTime.Now,
                PublishDate = DateTime.Now,
                ViewsCount = 17
            },
            new Post
            {
                Id = 13,
                Title = "Great Things Never Came from Comfort Zone",
                ImagePath = "image_2.jpg",
                Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis, eius " +
                "mollitia suscipit, quisquam doloremque distinctio perferendis et doloribus unde architecto optio " +
                "laboriosam porro adipisci sapiente officiis nemo accusamus ad praesentium? Esse minima nisi et. " +
                "Dolore perferendis, enim praesentium omnis, iste doloremque quia officia optio deserunt molestiae " +
                "voluptates soluta architecto tempora.",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                ArchiveId = 6,
                CategoryId = 3,
                AuthorId = 1,
                WrittenDate = DateTime.Now,
                PublishDate = DateTime.Now,
                ViewsCount = 12
            },
            new Post
            {
                Id = 14,
                Title = "Paths Are Made by Walking",
                ImagePath = "image_3.jpg",
                Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis, eius " +
                "mollitia suscipit, quisquam doloremque distinctio perferendis et doloribus unde architecto optio " +
                "laboriosam porro adipisci sapiente officiis nemo accusamus ad praesentium? Esse minima nisi et. " +
                "Dolore perferendis, enim praesentium omnis, iste doloremque quia officia optio deserunt molestiae " +
                "voluptates soluta architecto tempora.",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                ArchiveId = 8,
                CategoryId = 4,
                AuthorId = 1,
                WrittenDate = DateTime.Now,
                PublishDate = DateTime.Now,
                ViewsCount = 3
            },
            new Post
            {
                Id = 15,
                Title = "The Secret of Getting Ahead is Getting Started",
                ImagePath = "image_4.jpg",
                Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis, eius " +
                "mollitia suscipit, quisquam doloremque distinctio perferendis et doloribus unde architecto optio " +
                "laboriosam porro adipisci sapiente officiis nemo accusamus ad praesentium? Esse minima nisi et. " +
                "Dolore perferendis, enim praesentium omnis, iste doloremque quia officia optio deserunt molestiae " +
                "voluptates soluta architecto tempora.",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                ArchiveId = 2,
                CategoryId = 4,
                AuthorId = 1,
                WrittenDate = DateTime.Now,
                PublishDate = DateTime.Now,
                ViewsCount = 3
            },
            new Post
            {
                Id = 16,
                Title = "You Can't Blame Gravity for Falling in Love",
                ImagePath = "image_5.jpg",
                Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis, eius " +
                "mollitia suscipit, quisquam doloremque distinctio perferendis et doloribus unde architecto optio " +
                "laboriosam porro adipisci sapiente officiis nemo accusamus ad praesentium? Esse minima nisi et. " +
                "Dolore perferendis, enim praesentium omnis, iste doloremque quia officia optio deserunt molestiae " +
                "voluptates soluta architecto tempora.",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                ArchiveId = 3,
                CategoryId = 3,
                AuthorId = 1,
                WrittenDate = DateTime.Now,
                PublishDate = DateTime.Now,
                ViewsCount = 10
            },
            new Post
            {
                Id = 17,
                Title = "Great Things Never Came from Comfort Zone",
                ImagePath = "image_6.jpg",
                Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis, eius " +
                "mollitia suscipit, quisquam doloremque distinctio perferendis et doloribus unde architecto optio " +
                "laboriosam porro adipisci sapiente officiis nemo accusamus ad praesentium? Esse minima nisi et. " +
                "Dolore perferendis, enim praesentium omnis, iste doloremque quia officia optio deserunt molestiae " +
                "voluptates soluta architecto tempora.",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                ArchiveId = 4,
                CategoryId = 2,
                AuthorId = 1,
                WrittenDate = DateTime.Now,
                PublishDate = DateTime.Now,
                ViewsCount = 5
            },
            new Post
            {
                Id = 18,
                Title = "Great Things Never Came from Comfort Zone",
                ImagePath = "image_6.jpg",
                Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis, eius " +
                "mollitia suscipit, quisquam doloremque distinctio perferendis et doloribus unde architecto optio " +
                "laboriosam porro adipisci sapiente officiis nemo accusamus ad praesentium? Esse minima nisi et. " +
                "Dolore perferendis, enim praesentium omnis, iste doloremque quia officia optio deserunt molestiae " +
                "voluptates soluta architecto tempora.",
                ShortDescription = "Lorem ipsum dolor sit amet, consectetur adipisicing elit.",
                ArchiveId = 5,
                CategoryId = 2,
                AuthorId = 1,
                WrittenDate = DateTime.Now,
                PublishDate = DateTime.Now,
                ViewsCount = 5
            }

            );*/
            #endregion
        }
    }
}


