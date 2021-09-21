namespace AssignmentPart4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sec : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Insurances", "Base", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Insurances", "Base");
        }
    }
}
