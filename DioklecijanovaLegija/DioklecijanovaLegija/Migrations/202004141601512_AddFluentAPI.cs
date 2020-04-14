namespace DioklecijanovaLegija.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddFluentAPI : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE  FROM Members WHERE Id>52 AND Id<57");
            AlterColumn("dbo.Members", "Name", c => c.String(nullable: false, maxLength: 255));
        }

        public override void Down()
        {
            AlterColumn("dbo.Members", "Name", c => c.String());

        }
    }
}
