using Microsoft.AspNetCore.Mvc;

namespace ProjectHome.Controllers
{
    public class Demo : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
