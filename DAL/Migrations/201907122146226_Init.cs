namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Polls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedDate = c.DateTime(nullable: false),
                        Name = c.String(),
                        Email = c.String(),
                        Cellphone = c.String(),
                        Age = c.String(),
                        Province = c.String(),
                        Area = c.String(),
                        TimeToParticipate = c.String(),
                        TypeOfHelp = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Polls");
        }
    }
}
