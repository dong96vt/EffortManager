using Microsoft.AspNetCore.Mvc;

namespace SomeThingManager.Controllers
{
    public class FundController:Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}