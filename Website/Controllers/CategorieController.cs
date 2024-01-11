using Microsoft.AspNetCore.Mvc;
using BLL;

namespace Website.Controllers
{
    public class CategorieController : Controller
    {
        public IActionResult Index()
        {
            var service = new CategorieService();

            return View(service.ListVM());
        }
    }
}
