namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changingPolls : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Polls", "OtherTimeToParticipate", c => c.String());
            AddColumn("dbo.Polls", "OtherTypeOfHelp", c => c.String());
            AddColumn("dbo.Polls", "ProfessionInstitution", c => c.String());
            AddColumn("dbo.Polls", "Profession", c => c.String());
            AlterColumn("dbo.Polls", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Polls", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Polls", "Age", c => c.String(nullable: false));
            AlterColumn("dbo.Polls", "Province", c => c.String(nullable: false));
            AlterColumn("dbo.Polls", "Area", c => c.String(nullable: false));
            AlterColumn("dbo.Polls", "TypeOfHelp", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Polls", "TypeOfHelp", c => c.String());
            AlterColumn("dbo.Polls", "Area", c => c.String());
            AlterColumn("dbo.Polls", "Province", c => c.String());
            AlterColumn("dbo.Polls", "Age", c => c.String());
            AlterColumn("dbo.Polls", "Email", c => c.String());
            AlterColumn("dbo.Polls", "Name", c => c.String());
            DropColumn("dbo.Polls", "Profession");
            DropColumn("dbo.Polls", "ProfessionInstitution");
            DropColumn("dbo.Polls", "OtherTypeOfHelp");
            DropColumn("dbo.Polls", "OtherTimeToParticipate");
        }
    }
}
