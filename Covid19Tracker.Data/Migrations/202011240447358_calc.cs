namespace Covid19Tracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class calc : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CountyData", "RecordId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CountyData", "RecordId", c => c.Int(nullable: false));
        }
    }
}
