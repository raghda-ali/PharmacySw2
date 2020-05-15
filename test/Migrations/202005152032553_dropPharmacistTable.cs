namespace test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropPharmacistTable : DbMigration
    {
        public override void Up()
        {
            DropTable("Pharmacists");

        }

        public override void Down()
        {
        }
    }
}
