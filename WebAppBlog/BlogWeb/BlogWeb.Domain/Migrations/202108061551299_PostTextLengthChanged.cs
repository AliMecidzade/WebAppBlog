namespace BlogWeb.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PostTextLengthChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "ShortDescription", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Posts", "Text", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Text", c => c.String(nullable: false, maxLength: 700));
            AlterColumn("dbo.Posts", "ShortDescription", c => c.String(nullable: false, maxLength: 300));
        }
    }
}
