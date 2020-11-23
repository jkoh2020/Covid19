namespace Covid19Tracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newdatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CountyJoin",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountyId = c.Int(nullable: false),
                        DataId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.County", t => t.CountyId, cascadeDelete: true)
                .ForeignKey("dbo.CountyData", t => t.DataId, cascadeDelete: true)
                .Index(t => t.CountyId)
                .Index(t => t.DataId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CountyJoin", "DataId", "dbo.CountyData");
            DropForeignKey("dbo.CountyJoin", "CountyId", "dbo.County");
            DropIndex("dbo.CountyJoin", new[] { "DataId" });
            DropIndex("dbo.CountyJoin", new[] { "CountyId" });
            DropTable("dbo.CountyJoin");
        }
    }
}
