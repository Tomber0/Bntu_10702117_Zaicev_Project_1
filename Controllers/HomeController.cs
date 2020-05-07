using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bntu_10702117_Zaicev_Project_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string Id ="")
        {
             return View();
        }

    }
}
