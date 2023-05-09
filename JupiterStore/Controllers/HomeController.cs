using Microsoft.AspNetCore.Mvc;

namespace JupiterStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
