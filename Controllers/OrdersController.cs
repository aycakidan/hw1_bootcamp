using Microsoft.AspNetCore.Mvc;

namespace homework1_bootcampC_.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
