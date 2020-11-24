namespace Covid19Tracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datalist : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CountyDataCounty", "CountyData_DataId", "dbo.CountyData");
            DropForeignKey("dbo.CountyDataCounty", "County_CountyId", "dbo.County");
            DropIndex("dbo.CountyDataCounty", new[] { "CountyData_DataId" });
            DropIndex("dbo.CountyDataCounty", new[] { "County_CountyId" });
            CreateIndex("dbo.CountyData", "CountyId");
            AddForeignKey("dbo.CountyData", "CountyId", "dbo.County", "CountyId", cascadeDelete: true);
            DropTable("dbo.CountyDataCounty");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.CountyDataCounty",
                c => new
                    {
                        CountyData_DataId = c.Int(nullable: false),
                        County_CountyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CountyData_DataId, t.County_CountyId });
            
            DropForeignKey("dbo.CountyData", "CountyId", "dbo.County");
            DropIndex("dbo.CountyData", new[] { "CountyId" });
            CreateIndex("dbo.CountyDataCounty", "County_CountyId");
            CreateIndex("dbo.CountyDataCounty", "CountyData_DataId");
            AddForeignKey("dbo.CountyDataCounty", "County_CountyId", "dbo.County", "CountyId", cascadeDelete: true);
            AddForeignKey("dbo.CountyDataCounty", "CountyData_DataId", "dbo.CountyData", "DataId", cascadeDelete: true);
        }
    }
}
