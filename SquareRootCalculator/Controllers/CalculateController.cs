using Microsoft.AspNetCore.Mvc;

namespace SquareRootCalculator.Controllers
{
    public class CalculateController : Controller
    {
        public IActionResult Index()
        {
            return View();  
        }
    }
}
