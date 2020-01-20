using Microsoft.AspNetCore.Mvc;

namespace SomeThingManager.Controllers
{
    public class StatisticsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}