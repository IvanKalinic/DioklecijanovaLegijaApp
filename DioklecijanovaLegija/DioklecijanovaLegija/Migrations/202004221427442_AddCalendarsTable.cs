namespace DioklecijanovaLegija.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCalendarsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Calendars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        StartTime = c.DateTime(),
                        EndTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Calendars");
        }
    }
}
