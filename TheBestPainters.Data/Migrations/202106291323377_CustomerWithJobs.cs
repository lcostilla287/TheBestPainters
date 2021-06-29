namespace TheBestPainters.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerWithJobs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Job", "Interior", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Job", "Interior");
        }
    }
}
