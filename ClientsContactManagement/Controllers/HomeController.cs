using Microsoft.AspNetCore.Mvc;

namespace ClientsContactManagement.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
