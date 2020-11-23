namespace Covid19Tracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nothing : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CountyData", "RecordId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CountyData", "RecordId");
        }
    }
}
