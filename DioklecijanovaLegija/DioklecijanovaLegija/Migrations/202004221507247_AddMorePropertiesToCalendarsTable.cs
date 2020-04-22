namespace DioklecijanovaLegija.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMorePropertiesToCalendarsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Calendars", "ThemeColor", c => c.String());
            AddColumn("dbo.Calendars", "IsFullDay", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Calendars", "IsFullDay");
            DropColumn("dbo.Calendars", "ThemeColor");
        }
    }
}
