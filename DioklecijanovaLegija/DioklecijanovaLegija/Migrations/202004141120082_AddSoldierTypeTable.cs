namespace DioklecijanovaLegija.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSoldierTypeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SoldierTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Members", "SoldierTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Members", "SoldierTypeId");
            AddForeignKey("dbo.Members", "SoldierTypeId", "dbo.SoldierTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Members", "SoldierTypeId", "dbo.SoldierTypes");
            DropIndex("dbo.Members", new[] { "SoldierTypeId" });
            DropColumn("dbo.Members", "SoldierTypeId");
            DropTable("dbo.SoldierTypes");
        }
    }
}
