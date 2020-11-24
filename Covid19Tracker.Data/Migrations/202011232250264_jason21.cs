namespace Covid19Tracker.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jason21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.StateData", "StateId", c => c.Int(nullable: false));
            CreateIndex("dbo.StateData", "StateId");
            AddForeignKey("dbo.StateData", "StateId", "dbo.State", "StateId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StateData", "StateId", "dbo.State");
            DropIndex("dbo.StateData", new[] { "StateId" });
            DropColumn("dbo.StateData", "StateId");
        }
    }
}
