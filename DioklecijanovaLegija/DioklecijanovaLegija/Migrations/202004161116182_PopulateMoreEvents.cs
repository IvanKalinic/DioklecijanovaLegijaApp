namespace DioklecijanovaLegija.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateMoreEvents : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Events(Id,Name,DateOfEvent,NumberOfMembers,Location) VALUES (2,'Antički dani','19-Jul-2020 8:00:00 PM',16,'Omišalj,Krk')");
            Sql("INSERT INTO Events(Id,Name,DateOfEvent,NumberOfMembers,Location) VALUES (3,'Narona','26-Jul-2020 8:00:00 PM',14,'Vid,Metković')");
            Sql("INSERT INTO Events(Id,Name,DateOfEvent,NumberOfMembers,Location) VALUES (4,'Crna Gora','28-Jul-2020 8:00:00 PM',16,'Crna Gora')");
            Sql("INSERT INTO Events(Id,Name,DateOfEvent,NumberOfMembers,Location) VALUES (5,'Rimska noć','31-Jul-2020 8:00:00 PM',15,'Igrane')");
            Sql("INSERT INTO Events(Id,Name,DateOfEvent,NumberOfMembers,Location) VALUES (6,'Rogoznica','7-Aug-2020 8:00:00 PM',16,'Rogoznica')");
            Sql("INSERT INTO Events(Id,Name,DateOfEvent,NumberOfMembers,Location) VALUES (7,'Rimski đir','9-Aug-2020 8:00:00 PM',14,'Split')");
            Sql("INSERT INTO Events(Id,Name,DateOfEvent,NumberOfMembers,Location) VALUES (8,'Burnumske Ide','12-Aug-2020 8:00:00 PM',16,'NP Krka')");
            Sql("INSERT INTO Events(Id,Name,DateOfEvent,NumberOfMembers,Location) VALUES (9,'Ptuj','15-Aug-2020 8:00:00 PM',12,'Ptuj,Slovenija')");
            Sql("INSERT INTO Events(Id,Name,DateOfEvent,NumberOfMembers,Location) VALUES (10,'Rimski đir','27-Sep-2020 8:00:00 PM',14,'Split')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Events(Id,Name,DateOfEvent,NumberOfMembers,Location) VALUES (10,'Rimski đir','27-Sep-2020 8:00:00 PM',14,'Split')");
            Sql("DELETE FROM Events(Id,Name,DateOfEvent,NumberOfMembers,Location) VALUES (9,'Ptuj','15-Aug-2020 8:00:00 PM',12,'Ptuj,Slovenija')");
            Sql("DELETE FROM Events(Id,Name,DateOfEvent,NumberOfMembers,Location) VALUES (8,'Burnumske Ide','12-Aug-2020 8:00:00 PM',16,'NP Krka')");
            Sql("DELETE FROM Events(Id,Name,DateOfEvent,NumberOfMembers,Location) VALUES (7,'Rimski đir','9-Aug-2020 8:00:00 PM',14,'Split')");
            Sql("DELETE FROM Events(Id,Name,DateOfEvent,NumberOfMembers,Location) VALUES (6,'Rogoznica','7-Aug-2020 8:00:00 PM',16,'Rogoznica')");
            Sql("DELETE FROM Events(Id,Name,DateOfEvent,NumberOfMembers,Location) VALUES (5,'Rimska noć','31-Jul-2020 8:00:00 PM',15,'Igrane')");
            Sql("DELETE FROM Events(Id,Name,DateOfEvent,NumberOfMembers,Location) VALUES (4,'Crna Gora','28-Jul-2020 8:00:00 PM',16,'Crna Gora')");
            Sql("DELETE FROM Events(Id,Name,DateOfEvent,NumberOfMembers,Location) VALUES (3,'Narona','26-Jul-2020 8:00:00 PM',14,'Vid,Metković')");
            Sql("DELETE FROM Events(Id,Name,DateOfEvent,NumberOfMembers,Location) VALUES (2,'Antički dani','19-Jul-2020 8:00:00 PM',16,'Omišalj,Krk')");

        }
    }
}
