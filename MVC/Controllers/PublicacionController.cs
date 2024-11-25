using LogicaNegocio;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class PublicacionController : Controller
    {
        /// <summary>
        /// Permite mostrar a todas las publicaciones
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            ViewBag.ListaPublicaciones = Sistema.Instancia.Publicaciones;
            return View();
        }
    }
}
