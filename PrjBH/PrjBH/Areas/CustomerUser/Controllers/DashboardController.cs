using Microsoft.AspNetCore.Mvc;

namespace PrjBH.Areas.CustomerUser.Controllers
{
    public class DashboardController : BaseController
    {
        public IActionResult Index(int? id)
        {
            return View();
        }
    }
}
