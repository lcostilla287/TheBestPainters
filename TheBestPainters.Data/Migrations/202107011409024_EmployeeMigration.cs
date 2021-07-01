namespace TheBestPainters.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        OwnerId = c.Guid(nullable: false),
                        CrewId = c.Int(),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        StreetAddress = c.String(nullable: false),
                        CityAddress = c.String(nullable: false),
                        Email = c.String(),
                        IsCrewChief = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Crew", t => t.CrewId)
                .Index(t => t.CrewId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employee", "CrewId", "dbo.Crew");
            DropIndex("dbo.Employee", new[] { "CrewId" });
            DropTable("dbo.Employee");
        }
    }
}
