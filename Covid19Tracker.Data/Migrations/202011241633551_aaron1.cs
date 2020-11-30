namespace Covid19Tracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aaron1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CountyData", "TotalConfirmedCases", c => c.Int(nullable: false));
            AddColumn("dbo.CountyData", "TotalDeaths", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CountyData", "TotalDeaths");
            DropColumn("dbo.CountyData", "TotalConfirmedCases");
        }
    }
}
