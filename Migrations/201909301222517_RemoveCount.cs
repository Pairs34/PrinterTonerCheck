namespace PrinterTonerCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveCount : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.TonerCounts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TonerCounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PrinterName = c.String(),
                        PrinterId = c.Int(nullable: false),
                        C = c.Int(nullable: false),
                        M = c.Int(nullable: false),
                        Y = c.Int(nullable: false),
                        K = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
