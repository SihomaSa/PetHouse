using Microsoft.AspNetCore.Mvc;

namespace PetHouse.Controllers
{
    public class ReservacionesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
