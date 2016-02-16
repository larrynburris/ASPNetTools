using System.ComponentModel.DataAnnotations;
using Heroic.AutoMapper;
using ASPNetTools.Web.Core;

namespace ASPNetTools.Web.Models
{
	public class AddCustomerForm : IMapTo<Customer>
	{
		[Required, Display(Name = "Full Name", Prompt = "Full Name (ex: John Doe)...")]
		public string Name { get; set; }

		[Required, DataType(DataType.EmailAddress)]
		public string WorkEmail { get; set; }

		[DataType(DataType.EmailAddress)]
		public string HomeEmail { get; set; }

		[Required, DataType(DataType.PhoneNumber)]
		public string WorkPhone { get; set; }

		[DataType(DataType.PhoneNumber)]
		public string HomePhone { get; set; }

		[Required, DataType(DataType.MultilineText)]
		public string WorkAddress { get; set; }

		[DataType(DataType.MultilineText)]
		public string HomeAddress { get; set; }
	}
}