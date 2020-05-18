namespace PrinterTonerCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FourthMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Printers", "MailNeed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Printers", "MailNeed");
        }
    }
}
