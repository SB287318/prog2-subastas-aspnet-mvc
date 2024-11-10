using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class UsuarioClienteController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
