using Microsoft.AspNetCore.Mvc;

namespace CSIRO.Controllers
{
    public class Registration : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

