using System.Data.Entity;
using ASPNetTools.Web.Core;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ASPNetTools.Web.Data
{
	public class AppDbContext : IdentityDbContext<User>
	{

        public AppDbContext() { }

        public IDbSet<Customer> Customers { get; set; }

		public IDbSet<Opportunity> Opportunities { get; set; }

		public IDbSet<Risk> Risks { get; set; }
	}
}