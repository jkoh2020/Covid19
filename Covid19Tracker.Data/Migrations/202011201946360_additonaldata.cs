namespace Covid19Tracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class additonaldata : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CountyData", "TotalTests", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CountyData", "TotalTests");
        }
    }
}
