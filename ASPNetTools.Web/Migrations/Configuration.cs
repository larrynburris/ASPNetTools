using System.Data.Entity.Migrations;
using ASPNetTools.Web.Data;

namespace ASPNetTools.Web.Migrations
{
	internal sealed class Configuration : DbMigrationsConfiguration<AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AppDbContext context)
        {
            
        }
    }
}
