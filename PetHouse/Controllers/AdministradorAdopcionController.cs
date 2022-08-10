using Microsoft.AspNetCore.Mvc;

namespace PetHouse.Controllers
{
    public class AdministradorAdopcionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
