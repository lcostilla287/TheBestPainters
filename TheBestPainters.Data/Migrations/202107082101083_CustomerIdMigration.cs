namespace TheBestPainters.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomerIdMigration : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Job", name: "Id", newName: "CustomerId");
            RenameIndex(table: "dbo.Job", name: "IX_Id", newName: "IX_CustomerId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Job", name: "IX_CustomerId", newName: "IX_Id");
            RenameColumn(table: "dbo.Job", name: "CustomerId", newName: "Id");
        }
    }
}
