using System.Data.Entity.Migrations;

namespace WdProject.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<WdProject.EntityFramework.WdProjectDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WdProject";
        }

        protected override void Seed(WdProject.EntityFramework.WdProjectDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
