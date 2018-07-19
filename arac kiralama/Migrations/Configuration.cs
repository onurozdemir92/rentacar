namespace arac_kiralama.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<arac_kiralama.kiraveritabani>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "arac_kiralama.kiraveritabani";
        }

        protected override void Seed(arac_kiralama.kiraveritabani context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
