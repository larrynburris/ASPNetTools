using System.ComponentModel.DataAnnotations;
using AutoMapper;
using Heroic.AutoMapper;
using ASPNetTools.Web.Core;

namespace ASPNetTools.Web.Models
{
	public class ProfileForm : IMapFrom<User>, IHaveCustomMappings
	{
		public string FullName { get; set; }

		public string EmailAddress { get; set; }

		public void CreateMappings(IConfiguration configuration)
		{
			configuration.CreateMap<User, ProfileForm>()
				.ForMember(d => d.FullName, opt => opt.MapFrom(s => s.UserName))
				.ForMember(d => d.EmailAddress, opt => opt.MapFrom(s => s.Email));
		}
	}
}