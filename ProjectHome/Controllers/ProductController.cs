using Microsoft.AspNetCore.Mvc;

namespace ProjectHome.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
