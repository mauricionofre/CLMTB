namespace CLMTB.Infrastructure.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Athlete", "Address_Street", c => c.String());
            AddColumn("dbo.Athlete", "Address_Neighborhood", c => c.String());
            AddColumn("dbo.Athlete", "Address_Number", c => c.Int(nullable: false));
            AddColumn("dbo.Athlete", "Address_City", c => c.String());
            AddColumn("dbo.Athlete", "Address_UF", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Athlete", "Address_UF");
            DropColumn("dbo.Athlete", "Address_City");
            DropColumn("dbo.Athlete", "Address_Number");
            DropColumn("dbo.Athlete", "Address_Neighborhood");
            DropColumn("dbo.Athlete", "Address_Street");
        }
    }
}
