using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    [AllowAnonymous]
    public class IdentityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Login(IdentityLoginUserViewModel identityLoginUserViewModel)
        {
            return RedirectToAction("Dashboard", "Home");
        }
    }
}
