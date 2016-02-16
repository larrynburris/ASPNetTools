using System;
using Heroic.AutoMapper;
using ASPNetTools.Web.Core;

namespace ASPNetTools.Web.Models
{
	public class LostCustomerReportViewModel : IMapFrom<Customer>
	{
		public string Name { get; set; }

		public string WorkEmail { get; set; }

		public DateTime? TerminationDate { get; set; }
	}
}