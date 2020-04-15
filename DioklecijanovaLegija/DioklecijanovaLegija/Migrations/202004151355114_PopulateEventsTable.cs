namespace DioklecijanovaLegija.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateEventsTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Events(Id,Name,DateOfEvent,NumberOfMembers,Location) VALUES (1,'Dioklecijanove igre','30-May-2020 20:00:00 PM',16,'Dioklecijanovi podrumi')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Events(Id,Name,DateOfEvent,NumberOfMembers,Location) VALUES (1,'Dioklecijanove igre','30-May-2020 20:00:00 PM',16,'Dioklecijanovi podrumi')");
        }
    }
}
