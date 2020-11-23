namespace Covid19Tracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newdatabase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StateData", "StateId", "dbo.State");
            DropForeignKey("dbo.CountyData", "CountyId", "dbo.County");
            DropIndex("dbo.CountyData", new[] { "CountyId" });
            DropIndex("dbo.StateData", new[] { "StateId" });
            AddColumn("dbo.County", "CountyData_DataId", c => c.Int());
            CreateIndex("dbo.County", "CountyData_DataId");
            AddForeignKey("dbo.County", "CountyData_DataId", "dbo.CountyData", "DataId");
            DropColumn("dbo.StateData", "StateId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StateData", "StateId", c => c.Int(nullable: false));
            DropForeignKey("dbo.County", "CountyData_DataId", "dbo.CountyData");
            DropIndex("dbo.County", new[] { "CountyData_DataId" });
            DropColumn("dbo.County", "CountyData_DataId");
            CreateIndex("dbo.StateData", "StateId");
            CreateIndex("dbo.CountyData", "CountyId");
            AddForeignKey("dbo.CountyData", "CountyId", "dbo.County", "CountyId", cascadeDelete: true);
            AddForeignKey("dbo.StateData", "StateId", "dbo.State", "StateId", cascadeDelete: true);
        }
    }
}
