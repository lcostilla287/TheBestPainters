namespace TheBestPainters.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JobMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Job",
                c => new
                    {
                        JobId = c.Int(nullable: false, identity: true),
                        OwnerId = c.Guid(nullable: false),
                        CustomerId = c.Int(),
                        JobLocation = c.String(nullable: false),
                        ScopeOfWork = c.String(nullable: false),
                        Exterior = c.Boolean(nullable: false),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.JobId)
                .ForeignKey("dbo.Customer", t => t.CustomerId)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Job", "CustomerId", "dbo.Customer");
            DropIndex("dbo.Job", new[] { "CustomerId" });
            DropTable("dbo.Job");
        }
    }
}
