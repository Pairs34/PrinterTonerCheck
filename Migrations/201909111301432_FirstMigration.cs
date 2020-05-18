namespace PrinterTonerCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Printers", "CLevel", c => c.Int());
            AddColumn("dbo.Printers", "CName", c => c.String());
            DropColumn("dbo.Printers", "BLevel");
            DropColumn("dbo.Printers", "BName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Printers", "BName", c => c.String());
            AddColumn("dbo.Printers", "BLevel", c => c.Int());
            DropColumn("dbo.Printers", "CName");
            DropColumn("dbo.Printers", "CLevel");
        }
    }
}
