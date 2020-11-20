namespace Covid19Tracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedata : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.County", "UserId", c => c.Guid(nullable: false));
            AddColumn("dbo.CountyData", "UserId", c => c.Guid(nullable: false));
            AddColumn("dbo.State", "UserId", c => c.Guid(nullable: false));
            AddColumn("dbo.StateData", "UserId", c => c.Guid(nullable: false));
            DropColumn("dbo.County", "OwnerId");
            DropColumn("dbo.CountyData", "OwnerId");
            DropColumn("dbo.State", "OwnerId");
            DropColumn("dbo.StateData", "OwnerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.StateData", "OwnerId", c => c.Guid(nullable: false));
            AddColumn("dbo.State", "OwnerId", c => c.Guid(nullable: false));
            AddColumn("dbo.CountyData", "OwnerId", c => c.Guid(nullable: false));
            AddColumn("dbo.County", "OwnerId", c => c.Guid(nullable: false));
            DropColumn("dbo.StateData", "UserId");
            DropColumn("dbo.State", "UserId");
            DropColumn("dbo.CountyData", "UserId");
            DropColumn("dbo.County", "UserId");
        }
    }
}
