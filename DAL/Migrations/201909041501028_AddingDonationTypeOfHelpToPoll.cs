namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingDonationTypeOfHelpToPoll : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Polls", "DonationTypeOfHelp", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Polls", "DonationTypeOfHelp");
        }
    }
}
