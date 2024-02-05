using Microsoft.AspNetCore.Mvc;

namespace WebAppOne.Controllers
{
    public class DemoController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
