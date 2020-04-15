namespace DioklecijanovaLegija.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddEventsTableToDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                {
                    Id = c.Int(nullable: false),
                    Name = c.String(nullable: false),
                    DateOfEvent = c.DateTime(),
                    numberOfMembers = c.Int(nullable: false),
                    Location = c.String(),
                })
                .PrimaryKey(t => t.Id);

        }

        public override void Down()
        {
            DropTable("dbo.Events");
        }
    }
}
