using Microsoft.AspNetCore.Mvc;

namespace PetHouse.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
