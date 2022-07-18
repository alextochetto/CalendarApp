using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class IdentityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
