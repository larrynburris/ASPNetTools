using ASPNetTools.Web.Core;
using Microsoft.AspNet.Identity;

namespace ASPNetTools.Web.Identity
{
	public class ApplicationUserManager : UserManager<User>
	{
		public ApplicationUserManager(IUserStore<User> store)
			: base(store)
		{
			UserValidator = new UserValidator<User>(this)
			{
				AllowOnlyAlphanumericUserNames = false,
				RequireUniqueEmail = true
			};
		}
	}
}