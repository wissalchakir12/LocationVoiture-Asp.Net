using BLL;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Security.Claims;

namespace Admin.Controllers
{
	public class AuthController : Controller
	{
		public IActionResult Index()
		{
			ClaimsPrincipal claimUser = HttpContext.User;

			if (claimUser.Identity.IsAuthenticated)
				return RedirectToAction("Index", "Home");
			return View();
		}
		[HttpPost]
		/// UserAuthVM encapsule les données provenant du formulaire 
		public IActionResult Index(UserAuthVM obj)
		{
			


			
			return View();
		}
	}
}
