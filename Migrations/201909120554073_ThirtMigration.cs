namespace PrinterTonerCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirtMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Printers", "Model", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Printers", "Model");
        }
    }
}
