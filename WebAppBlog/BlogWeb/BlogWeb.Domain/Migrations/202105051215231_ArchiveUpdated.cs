namespace BlogWeb.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ArchiveUpdated : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Archives", "Year", c => c.String(nullable: false, maxLength: 4));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Archives", "Year", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
