using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using BLL;
using Models;

namespace Admin.Controllers
{
	[Authorize]
	public class VoitureController : Controller
	{
		static VoitureService vs  = new VoitureService();
		public IActionResult Index(int id)
		{
			return View(vs.ListVoiture(id));
		}

		// Get de la méthode
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(VoitureVM voiture)
		{
			vs.Create(voiture);
			return RedirectToAction("Index");
		}

		public IActionResult Delete(int id)
		{
			vs.Delete(id);
			return RedirectToAction("Index");
		}

		public IActionResult Update(int id)
		{
			return View(vs.Get(id));
		}

		[HttpPost]
		public IActionResult Update(VoitureVM voiture) 
		{
			vs.Update(voiture);
			return RedirectToAction("Index");
		}

		public IActionResult Detail(int id)
		{
			return View(vs.DetailVoiture(id));
		}
	}
}
