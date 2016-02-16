using Heroic.AutoMapper;
using ASPNetTools.Web.Core;

namespace ASPNetTools.Web.Models
{
	public class CustomerOpportunityViewModel : IMapFrom<Opportunity>
	{
		public string Title { get; set; }

		public string Description { get; set; }
	}
}