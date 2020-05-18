namespace PrinterTonerCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Printers", "SnmpVersion", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Printers", "SnmpVersion");
        }
    }
}
