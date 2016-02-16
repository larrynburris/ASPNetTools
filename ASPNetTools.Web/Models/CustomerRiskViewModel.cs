using Heroic.AutoMapper;
using ASPNetTools.Web.Core;

namespace ASPNetTools.Web.Models
{
	public class CustomerRiskViewModel : IMapFrom<Risk>
	{
		public string Title { get; set; }

		public string Description { get; set; }
	}
}