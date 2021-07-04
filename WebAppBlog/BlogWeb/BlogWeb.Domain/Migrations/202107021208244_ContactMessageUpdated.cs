namespace BlogWeb.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactMessageUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ContactMessages", "Subject", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ContactMessages", "Subject");
        }
    }
}
