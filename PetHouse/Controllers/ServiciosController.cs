using Microsoft.AspNetCore.Mvc;

namespace PetHouse.Controllers
{
    public class ServiciosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
