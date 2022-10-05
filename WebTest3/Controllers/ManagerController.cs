using Microsoft.AspNetCore.Mvc;

namespace WebTest3.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
