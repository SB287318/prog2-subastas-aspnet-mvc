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
            try
            {

                int idUsuario = (int)HttpContext.Session.GetInt32("idUsuarioCliente");
                Usuario usuario = Sistema.Instancia.BuscarUsuarioPorId(idUsuario);
                if (HttpContext.Session.GetInt32("idUsuarioCliente") != null && usuario != null && usuario is UsuarioCliente)
                {
                    ViewBag.ListaPublicaciones = Sistema.Instancia.Publicaciones;
                    return View();
                }
            }
            catch (Exception ex)
            {

            }

            return RedirectToAction("Login", "Home");
        }
    }
}
