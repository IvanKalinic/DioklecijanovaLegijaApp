namespace DioklecijanovaLegija.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateCalendarsTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Calendars(Description,StartTime,EndTime) VALUES ('Legionarski trening','1-Jun-2020 6:00:00 PM','1-Jun-2020 8:00:00 PM')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Calendars(Description,StartTime,EndTime) VALUES ('Legionarski trening','1-Jun-2020 6:00:00 PM','1-Jun-2020 8:00:00 PM')");
        }
    }
}
