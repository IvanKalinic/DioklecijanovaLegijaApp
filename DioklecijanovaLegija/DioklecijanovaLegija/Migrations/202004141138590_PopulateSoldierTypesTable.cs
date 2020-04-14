namespace DioklecijanovaLegija.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateSoldierTypesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO SoldierTypes(Id,Type) VALUES(1,'Legionar')");
            Sql("INSERT INTO SoldierTypes(Id,Type) VALUES(2,'Gladijator')");
            Sql("INSERT INTO SoldierTypes(Id,Type) VALUES(3,'Signifer')");
            Sql("INSERT INTO SoldierTypes(Id,Type) VALUES(4,'Centurion')");
            Sql("INSERT INTO SoldierTypes(Id,Type) VALUES(5,'Bubnjar')");
        }

        public override void Down()
        {
        }
    }
}
