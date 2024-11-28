using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace L10_CustomAuthorize.Controllers
{
    public class AdminController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
