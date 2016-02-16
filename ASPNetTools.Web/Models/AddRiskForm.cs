using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Heroic.AutoMapper;
using ASPNetTools.Web.Core;

namespace ASPNetTools.Web.Models
{
	public class AddRiskForm : IMapTo<Risk>
	{
		[HiddenInput]
		public int CustomerId { get; set; }

		[Required]
		public string Title { get; set; }

		[DataType(DataType.MultilineText)]
		public string Description { get; set; }
	}
}