using Microsoft.AspNetCore.Mvc;

namespace WebTest3.Controllers
{
    public class ManagerController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
           
            return View();
        }
    }
}
