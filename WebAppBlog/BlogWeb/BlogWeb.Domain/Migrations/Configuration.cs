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
                Id = 3,
                Name = "Contact",
                Action = "Index",
                Controller = "Contact",
                IsActive = true

            },
            new Menu
              {
                  Id = 4,
                  Name = "About",
                  Action = "Index",
                  Controller = "About",
                  IsActive = true
              }
            );
            context.Categories.AddOrUpdate(new Category
            {
                Id = 1,
                Name = "Fashion",

            },
              new Category
             {
                 Id = 2,
                 Name = "Technology",

             },
              new Category
            {
                Id = 3,
                Name = "Travel",

            },
              new Category
              {
                  Id = 4,
                  Name = "Food",

              },
              new Category
               {
                   Id = 5,
                   Name = "Photography",

               });
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
             context.Archives.AddOrUpdate(new Archive
             {
                 Id = 1,
                 Month = "December" ,
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

                ImagePath = "person_1.jpg"
            });
            context.Authors.AddOrUpdate(new Author
            {
                Id = 1,
                UserId = 1,
                Description = @"G"
            });


            //Джон Смит (англ. John Smith; 9 января 1580, Уиллоуби — 21 июня (1 июля) 1631, Лондон) — английский писатель и моряк, стоявший у истоков Джеймстауна

        }
    }
}
