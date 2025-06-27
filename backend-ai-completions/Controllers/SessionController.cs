using Microsoft.AspNetCore.Mvc;

namespace backend_ai_completions.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
