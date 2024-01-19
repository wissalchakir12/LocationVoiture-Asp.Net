using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
	public class VoitureController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
