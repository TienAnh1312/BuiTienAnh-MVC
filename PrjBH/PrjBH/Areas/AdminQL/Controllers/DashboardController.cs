using Microsoft.AspNetCore.Mvc;

namespace PrjBH.Areas.AdminQL.Controllers
{
    public class DashboardController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
