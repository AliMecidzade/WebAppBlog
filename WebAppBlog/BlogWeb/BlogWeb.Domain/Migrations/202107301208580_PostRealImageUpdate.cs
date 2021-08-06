namespace BlogWeb.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PostRealImageUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "ImageData", c => c.Binary(nullable: false));
            AddColumn("dbo.Posts", "ImageMimeType", c => c.String(nullable: false));
            DropColumn("dbo.Posts", "ImagePath");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "ImagePath", c => c.String(nullable: false, maxLength: 300));
            DropColumn("dbo.Posts", "ImageMimeType");
            DropColumn("dbo.Posts", "ImageData");
        }
    }
}
