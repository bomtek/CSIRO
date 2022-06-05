using Microsoft.AspNetCore.Mvc;

namespace CSIRO.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserApplication()
        {
            return View();
        }
    }
}
