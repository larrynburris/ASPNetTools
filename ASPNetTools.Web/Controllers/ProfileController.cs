﻿using System.Web.Mvc;
using AutoMapper;
using ASPNetTools.Web.Identity;
using ASPNetTools.Web.Models;
using Microsoft.AspNet.Identity;

namespace ASPNetTools.Web.Controllers
{
	public class ProfileController : HeroicCRMControllerBase
	{
		private readonly ApplicationUserManager _userManager;

		public ProfileController(ApplicationUserManager userManager)
		{
			_userManager = userManager;
		}

		public ActionResult Index()
		{
			var model = Mapper.Map<ProfileForm>(_userManager.FindById(User.Identity.GetUserId()));
			return View(model);
		}

		public JsonResult Update(ProfileForm form)
		{
			var user = _userManager.FindById(User.Identity.GetUserId());
			user.Email = form.EmailAddress;
			user.UserName = form.FullName;
			_userManager.Update(user);

			return Json(true);
		}
	}
}