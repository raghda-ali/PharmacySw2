namespace test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTablePharmacist : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pharmacists",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        EmailID = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        IsEmailVerified = c.Boolean(nullable: false),
                        ActivationCode = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pharmacists");
        }
    }
}
