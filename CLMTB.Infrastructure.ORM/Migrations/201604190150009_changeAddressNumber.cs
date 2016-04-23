namespace CLMTB.Infrastructure.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeAddressNumber : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Athlete", "Email", c => c.String(maxLength: 4000));
            AlterColumn("dbo.Athlete", "Address_Number", c => c.String(maxLength: 4000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Athlete", "Address_Number", c => c.Int(nullable: false));
            DropColumn("dbo.Athlete", "Email");
        }
    }
}
