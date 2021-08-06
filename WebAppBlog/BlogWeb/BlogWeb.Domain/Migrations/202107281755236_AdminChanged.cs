namespace BlogWeb.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "Title", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Posts", "ShortDescription", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Posts", "ImagePath", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Posts", "ImagePath", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Posts", "ShortDescription", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Posts", "Title", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
