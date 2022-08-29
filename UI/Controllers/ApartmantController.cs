using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class ApartmantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
