namespace BlogWeb.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaginationUpdated : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "Post_Id", "dbo.Posts");
            DropIndex("dbo.Comments", new[] { "Post_Id" });
            RenameColumn(table: "dbo.Comments", name: "Post_Id", newName: "PostId");
            AddColumn("dbo.Comments", "SubmmittedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.ContactMessages", "SubmmittedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Posts", "Text", c => c.String(nullable: false, maxLength: 700));
            AlterColumn("dbo.Posts", "ShortDescription", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Posts", "ImagePath", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Comments", "Email", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Comments", "PostId", c => c.Int(nullable: false));
            AlterColumn("dbo.ContactMessages", "Email", c => c.String(nullable: false, maxLength: 40));
            AlterColumn("dbo.Menus", "Controller", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Menus", "Action", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Comments", "PostId");
            AddForeignKey("dbo.Comments", "PostId", "dbo.Posts", "Id", cascadeDelete: false);
            DropColumn("dbo.Posts", "Website");
            DropColumn("dbo.Comments", "SubmittedDate");
            DropColumn("dbo.ContactMessages", "SubmittedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ContactMessages", "SubmittedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Comments", "SubmittedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Posts", "Website", c => c.String(nullable: false, maxLength: 50));
            DropForeignKey("dbo.Comments", "PostId", "dbo.Posts");
            DropIndex("dbo.Comments", new[] { "PostId" });
            AlterColumn("dbo.Menus", "Action", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Menus", "Controller", c => c.String(maxLength: 50));
            AlterColumn("dbo.ContactMessages", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Comments", "PostId", c => c.Int());
            AlterColumn("dbo.Comments", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Users", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Posts", "ImagePath", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Posts", "ShortDescription", c => c.String(nullable: false, maxLength: 2000));
            AlterColumn("dbo.Posts", "Text", c => c.String(nullable: false));
            DropColumn("dbo.ContactMessages", "SubmmittedDate");
            DropColumn("dbo.Comments", "SubmmittedDate");
            RenameColumn(table: "dbo.Comments", name: "PostId", newName: "Post_Id");
            CreateIndex("dbo.Comments", "Post_Id");
            AddForeignKey("dbo.Comments", "Post_Id", "dbo.Posts", "Id");
        }
    }
}
