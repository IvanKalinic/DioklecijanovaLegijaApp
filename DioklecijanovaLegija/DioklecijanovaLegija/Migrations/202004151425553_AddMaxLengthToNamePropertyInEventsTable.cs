namespace DioklecijanovaLegija.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMaxLengthToNamePropertyInEventsTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "Name", c => c.String(nullable: false));
        }
    }
}
