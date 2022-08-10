using Microsoft.AspNetCore.Mvc;

namespace PetHouse.Controllers
{
    public class AdoptameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
