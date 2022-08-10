using Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace PetHouse.Controllers
{
    public class ProductoController : Controller
    {
        private readonly PETHOUSEContext contexto;

        public ProductoController(PETHOUSEContext contexto) {
            this.contexto = contexto;
        }
        public async Task<IActionResult> Index()
        {
            var lista = await contexto.Producto.ToListAsync();
            return View(lista);
        }
    }
}
