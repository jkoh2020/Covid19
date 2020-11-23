namespace Covid19Tracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jason2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.County", "CountyData_DataId", "dbo.CountyData");
            DropIndex("dbo.County", new[] { "CountyData_DataId" });
            CreateIndex("dbo.CountyData", "CountyId");
            AddForeignKey("dbo.CountyData", "CountyId", "dbo.County", "CountyId", cascadeDelete: true);
            DropColumn("dbo.County", "CountyData_DataId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.County", "CountyData_DataId", c => c.Int());
            DropForeignKey("dbo.CountyData", "CountyId", "dbo.County");
            DropIndex("dbo.CountyData", new[] { "CountyId" });
            CreateIndex("dbo.County", "CountyData_DataId");
            AddForeignKey("dbo.County", "CountyData_DataId", "dbo.CountyData", "DataId");
        }
    }
}
