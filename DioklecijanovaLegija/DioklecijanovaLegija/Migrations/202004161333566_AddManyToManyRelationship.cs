namespace DioklecijanovaLegija.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddManyToManyRelationship : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MemberEvent",
                c => new
                    {
                        MemberRefId = c.Int(nullable: false),
                        EventRefId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MemberRefId, t.EventRefId })
                .ForeignKey("dbo.Members", t => t.MemberRefId, cascadeDelete: true)
                .ForeignKey("dbo.Events", t => t.EventRefId, cascadeDelete: true)
                .Index(t => t.MemberRefId)
                .Index(t => t.EventRefId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MemberEvent", "EventRefId", "dbo.Events");
            DropForeignKey("dbo.MemberEvent", "MemberRefId", "dbo.Members");
            DropIndex("dbo.MemberEvent", new[] { "EventRefId" });
            DropIndex("dbo.MemberEvent", new[] { "MemberRefId" });
            DropTable("dbo.MemberEvent");
        }
    }
}
