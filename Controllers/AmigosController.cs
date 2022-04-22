using Microsoft.AspNetCore.Mvc;

namespace CoreMVCEntityFramework.Controllers
{
    public class AmigosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
