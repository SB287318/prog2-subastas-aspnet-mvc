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
                if (HttpContext.Session.GetInt32("idUsuarioCliente") != null)
                {
                    int idUsuario = (int)HttpContext.Session.GetInt32("idUsuarioCliente");
                    Usuario usuario = Sistema.Instancia.BuscarUsuarioPorId(idUsuario);
                    if (usuario != null && usuario is UsuarioCliente)
                    {
                        ViewBag.ListaPublicaciones = Sistema.Instancia.Publicaciones;
                        return View();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("Login", "Home");
        }

        /// <summary>
        /// Muestra la lista de subastas ordenadas por fecha de publicación
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult MostrarListaSubastas()
        {
            try
            {
                if (HttpContext.Session.GetInt32("idUsuarioCliente") != null)
                {
                    int idUsuario = (int)HttpContext.Session.GetInt32("idUsuarioCliente");
                    Usuario usuario = Sistema.Instancia.BuscarUsuarioPorId(idUsuario);
                    if (usuario != null && usuario is not UsuarioCliente)
                    {
                        ViewBag.ListaPublicacionesSubasta = Sistema.Instancia.DevolverPublicacionesDeTipoSubasta();
                        return View();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return RedirectToAction("Login", "Home");
        }
    }
}
