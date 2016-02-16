using System.Data.Entity;
using ASPNetTools.Web.Data;

namespace ASPNetTools.Web
{
	public static class EFConfig
	{
		public static void Initialize()
		{
			Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AppDbContext>());
		}
	}
}