namespace Covid19Tracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class additional : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.County", "OwnerId", c => c.Guid(nullable: false));
            AddColumn("dbo.CountyData", "OwnerId", c => c.Guid(nullable: false));
            AddColumn("dbo.State", "OwnerId", c => c.Guid(nullable: false));
            AddColumn("dbo.StateData", "OwnerId", c => c.Guid(nullable: false));
            DropColumn("dbo.CountyData", "TotalTests");
            DropColumn("dbo.CountyData", "TotalConfirmedCases");
            DropColumn("dbo.CountyData", "TotalDeaths");
            DropColumn("dbo.StateData", "TotalTests");
            DropColumn("dbo.StateData", "TotalConfirmedCases");
            DropColumn("dbo.StateData", "TotalDeaths");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StateData", "TotalDeaths", c => c.Int(nullable: false));
            AddColumn("dbo.StateData", "TotalConfirmedCases", c => c.Int(nullable: false));
            AddColumn("dbo.StateData", "TotalTests", c => c.Int(nullable: false));
            AddColumn("dbo.CountyData", "TotalDeaths", c => c.Int(nullable: false));
            AddColumn("dbo.CountyData", "TotalConfirmedCases", c => c.Int(nullable: false));
            AddColumn("dbo.CountyData", "TotalTests", c => c.Int(nullable: false));
            DropColumn("dbo.StateData", "OwnerId");
            DropColumn("dbo.State", "OwnerId");
            DropColumn("dbo.CountyData", "OwnerId");
            DropColumn("dbo.County", "OwnerId");
        }
    }
}
