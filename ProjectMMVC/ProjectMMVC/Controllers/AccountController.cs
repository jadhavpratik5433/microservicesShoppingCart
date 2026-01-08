using Microsoft.AspNetCore.Mvc;

namespace ProjectMMVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
