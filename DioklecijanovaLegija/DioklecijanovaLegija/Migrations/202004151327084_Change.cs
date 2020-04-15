namespace DioklecijanovaLegija.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Change : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Events", "numberOfMembers", "NumberOfMembers");
        }

        public override void Down()
        {
            RenameColumn("dbo.Events", "NumberOfMembers", "numberOfMembers");
        }
    }
}
