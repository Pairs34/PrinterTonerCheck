namespace PrinterTonerCheck.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Count2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TonerCounts", "Count");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TonerCounts", "Count", c => c.Int(nullable: false));
        }
    }
}
