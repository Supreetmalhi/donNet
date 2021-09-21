namespace AssignmentPart4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inita : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Insurances",
                c => new
                    {
                        InsuranceID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Age = c.Int(nullable: false),
                        CarName = c.String(),
                        CarModel = c.String(),
                        CarYear = c.Int(nullable: false),
                        SpeedingTicket = c.Int(nullable: false),
                        DUI = c.Boolean(nullable: false),
                        FullCoverage = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.InsuranceID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Insurances");
        }
    }
}
