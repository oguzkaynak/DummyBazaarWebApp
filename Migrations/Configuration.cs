namespace DummyBazaarWebApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DummyBazaarWebApp.Models.DummyBazaarModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DummyBazaarWebApp.Models.DummyBazaarModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.ManegerTypes.AddOrUpdate(n => n.ID, new Models.ManegerType() { ID = 1, Name = "Admin" });
            context.ManegerTypes.AddOrUpdate(n => n.ID, new Models.ManegerType() { ID = 2, Name = "Moderatör" });
        }
    }
}
