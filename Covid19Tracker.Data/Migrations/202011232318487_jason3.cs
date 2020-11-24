namespace Covid19Tracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jason3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CountyData", "CountyId", "dbo.County");
            DropIndex("dbo.CountyData", new[] { "CountyId" });
            CreateTable(
                "dbo.CountyDataCounty",
                c => new
                    {
                        CountyData_DataId = c.Int(nullable: false),
                        County_CountyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CountyData_DataId, t.County_CountyId })
                .ForeignKey("dbo.CountyData", t => t.CountyData_DataId, cascadeDelete: true)
                .ForeignKey("dbo.County", t => t.County_CountyId, cascadeDelete: true)
                .Index(t => t.CountyData_DataId)
                .Index(t => t.County_CountyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CountyDataCounty", "County_CountyId", "dbo.County");
            DropForeignKey("dbo.CountyDataCounty", "CountyData_DataId", "dbo.CountyData");
            DropIndex("dbo.CountyDataCounty", new[] { "County_CountyId" });
            DropIndex("dbo.CountyDataCounty", new[] { "CountyData_DataId" });
            DropTable("dbo.CountyDataCounty");
            CreateIndex("dbo.CountyData", "CountyId");
            AddForeignKey("dbo.CountyData", "CountyId", "dbo.County", "CountyId", cascadeDelete: true);
        }
    }
}
