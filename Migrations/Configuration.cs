namespace PrinterTonerCheck.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PrinterTonerCheck.Model.Context.DbHelper>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "PrinterTonerCheck.Model.Context.DbHelper";
        }

        protected override void Seed(PrinterTonerCheck.Model.Context.DbHelper context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
