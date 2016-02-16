using System;
using Heroic.AutoMapper;

namespace ASPNetTools.Web.Models
{
	public class NewCustomerReportViewModel : IMapFrom<Core.Customer>
	{
		public string Name { get; set; }

		public string WorkEmail { get; set; }

		public DateTime CreateDate { get; set; }
	}
}