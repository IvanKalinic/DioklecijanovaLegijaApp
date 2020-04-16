namespace DioklecijanovaLegija.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateMemberEventTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MemberEvent VALUES (37,1)");
            Sql("INSERT INTO MemberEvent VALUES (37,2)");
            Sql("INSERT INTO MemberEvent VALUES (37,3)");
        }

        public override void Down()
        {
            Sql("DELETE FROM MemberEvent VALUES (37,3)");
            Sql("DELETE FROM MemberEvent VALUES (37,2)");
            Sql("DELETE FROM MemberEvent VALUES (37,1)");
        }
    }
}
