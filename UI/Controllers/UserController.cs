using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Url = "https://localhost:44346";
            return View();
        }
    }
}
