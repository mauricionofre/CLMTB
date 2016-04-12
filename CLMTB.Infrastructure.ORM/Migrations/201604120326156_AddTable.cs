namespace CLMTB.Infrastructure.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Athlete",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CPF = c.String(),
                        RG = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        BloodType = c.String(),
                        Fone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Athlete");
        }
    }
}
