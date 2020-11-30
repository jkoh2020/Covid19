namespace Covid19Tracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aaron3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CountyData", "TotalTests");
            DropColumn("dbo.CountyData", "TotalConfirmedCases");
            DropColumn("dbo.CountyData", "TotalDeaths");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CountyData", "TotalDeaths", c => c.Int(nullable: false));
            AddColumn("dbo.CountyData", "TotalConfirmedCases", c => c.Int(nullable: false));
            AddColumn("dbo.CountyData", "TotalTests", c => c.Int(nullable: false));
        }
    }
}
