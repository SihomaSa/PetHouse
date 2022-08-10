using Microsoft.AspNetCore.Mvc;

namespace PetHouse.Controllers
{
    public class AdministradorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
