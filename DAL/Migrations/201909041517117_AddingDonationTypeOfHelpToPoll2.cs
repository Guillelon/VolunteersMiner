namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDonationTypeOfHelpToPoll2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Polls", "TypeOfHelp", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Polls", "TypeOfHelp", c => c.String(nullable: false));
        }
    }
}
