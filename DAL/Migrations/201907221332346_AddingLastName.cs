namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingLastName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Polls", "FirstName", c => c.String(nullable: false));
            AddColumn("dbo.Polls", "LastName", c => c.String(nullable: false));
            DropColumn("dbo.Polls", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Polls", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Polls", "LastName");
            DropColumn("dbo.Polls", "FirstName");
        }
    }
}
