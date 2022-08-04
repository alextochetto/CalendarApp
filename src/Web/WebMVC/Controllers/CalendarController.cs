using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    [Route("/api/[controller]/[action]")]
    public class CalendarController : ControllerBase
    {
        [HttpGet]
        public string GetEvents()
        {
            return string.Empty;
        }
    }
}
