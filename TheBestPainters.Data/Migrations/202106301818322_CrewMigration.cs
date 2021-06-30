namespace TheBestPainters.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrewMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Crew",
                c => new
                    {
                        CrewId = c.Int(nullable: false, identity: true),
                        OwnerId = c.Guid(nullable: false),
                        CrewName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CrewId);
            
            AddColumn("dbo.Job", "CrewId", c => c.Int());
            CreateIndex("dbo.Job", "CrewId");
            AddForeignKey("dbo.Job", "CrewId", "dbo.Crew", "CrewId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Job", "CrewId", "dbo.Crew");
            DropIndex("dbo.Job", new[] { "CrewId" });
            DropColumn("dbo.Job", "CrewId");
            DropTable("dbo.Crew");
        }
    }
}
