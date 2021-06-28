namespace BlogWeb.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ViewsCountAddedToPost : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "ViewsCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "ViewsCount");
        }
    }
}
