using System;

namespace ASPNetTools.Web.Core
{
	public class Risk
	{
		public int Id { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public DateTime CreateDate { get; set; }

		public Customer Customer { get; set; }

		public Risk()
		{
			CreateDate = DateTime.Today;
		}
	}
}