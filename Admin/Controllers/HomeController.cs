using Admin.Models;
using BLL;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Diagnostics;
using DAL.Entity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace Admin.Controllers
{
	[Authorize]
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			CategorieService categorieService = new CategorieService();
			
			return View(categorieService.ListVM());
		}
		
		// Get de create
		
		public IActionResult Create()
		{
			return View();
		}
		//Post
		[HttpPost]
		public IActionResult Create(CategorieVM model)
		{
			try
			{
				CategorieService categorieService = new CategorieService();

				categorieService.AddCategorie(model);
				return RedirectToAction("Index");
			}
			catch 
			{
				return View();
			}
		}


		//Get de Update
		public IActionResult Update(int id) 
		{
			CategorieService categorieService= new CategorieService();
			CategorieVM cate =  categorieService.GetCategorie(id);
			return View(cate);
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Update(CategorieVM model)
		{
			try
			{
				CategorieService categorieService = new CategorieService();
				categorieService.UpdateCategorie(model);
				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}



		public IActionResult Delete(int id)
		{
				CategorieService categorieService = new CategorieService();
				categorieService.SupprimerCategorie(id);
				return RedirectToAction("Index");
		}





        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Auth");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}