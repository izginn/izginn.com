using Microsoft.AspNetCore.Mvc;

namespace izginn.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
