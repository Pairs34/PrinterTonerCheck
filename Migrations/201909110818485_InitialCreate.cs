namespace PrinterTonerCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Printers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Tip = c.Int(nullable: false),
                        Ip = c.String(),
                        LastRun = c.DateTime(),
                        NextRun = c.DateTime(),
                        BLevel = c.Int(),
                        YLevel = c.Int(),
                        MLevel = c.Int(),
                        KLevel = c.Int(),
                        KName = c.String(),
                        YName = c.String(),
                        MName = c.String(),
                        BName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Printers");
        }
    }
}
