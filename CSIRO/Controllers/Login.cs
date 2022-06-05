using Microsoft.AspNetCore.Mvc;

namespace CSIRO.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
