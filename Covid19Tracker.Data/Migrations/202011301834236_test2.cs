namespace Covid19Tracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CountyData", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.StateData", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.StateData", "Date");
            DropColumn("dbo.CountyData", "Date");
        }
    }
}
