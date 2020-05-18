namespace PrinterTonerCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TOnerCount : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TonerCounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Count = c.Int(nullable: false),
                        PrinterName = c.String(),
                        PrinterId = c.Int(nullable: false),
                        C = c.Int(nullable: false),
                        M = c.Int(nullable: false),
                        Y = c.Int(nullable: false),
                        K = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TonerCounts");
        }
    }
}
