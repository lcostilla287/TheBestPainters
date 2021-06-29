namespace TheBestPainters.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Materials : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Material",
                c => new
                    {
                        MaterialId = c.Int(nullable: false, identity: true),
                        OwnerId = c.Guid(nullable: false),
                        JobId = c.Int(),
                        MaterialName = c.String(nullable: false),
                        Price = c.Double(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaterialId)
                .ForeignKey("dbo.Job", t => t.JobId)
                .Index(t => t.JobId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Material", "JobId", "dbo.Job");
            DropIndex("dbo.Material", new[] { "JobId" });
            DropTable("dbo.Material");
        }
    }
}
