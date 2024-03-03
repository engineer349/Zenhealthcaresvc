using Microsoft.AspNetCore.Mvc;
using System.Net.Security;

namespace Zenhealthcareservice.Controller
{
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }



    }
}
