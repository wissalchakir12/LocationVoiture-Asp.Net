using BLL;
using Microsoft.AspNetCore.Mvc;

namespace Website.Controllers
{
    public class VoitureController : Controller
    {
        public IActionResult Index(int id)
        {
            
            if (id == 0 || id == null) 
            { 
                return NotFound();
            }
            VoitureService vs = new VoitureService();
            return View(vs.ListVoiture(id));
        }
        public IActionResult Detail(int id)
        {
            VoitureService vs = new VoitureService();
            return View(vs.DetailVoiture(id));
        }
    }
}
