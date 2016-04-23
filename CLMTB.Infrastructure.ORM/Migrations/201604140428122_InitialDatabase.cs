namespace CLMTB.Infrastructure.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Athlete",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                        CPF = c.String(maxLength: 4000),
                        RG = c.String(maxLength: 4000),
                        BirthDate = c.DateTime(nullable: false),
                        BloodType = c.Int(nullable: false),
                        Fone = c.String(maxLength: 4000),
                        Gender = c.String(maxLength: 4000),
                        Address_Street = c.String(maxLength: 4000),
                        Address_Neighborhood = c.String(maxLength: 4000),
                        Address_Number = c.Int(nullable: false),
                        Address_City = c.String(maxLength: 4000),
                        Address_UF = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropTable("dbo.Athlete");
        }
    }
}