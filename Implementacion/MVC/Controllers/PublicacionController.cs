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
                if (HttpContext.Session.GetInt32("idUsuarioAdmin") != null)
                {
                    int idUsuario = (int)HttpContext.Session.GetInt32("idUsuarioAdmin");
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

        /*[HttpPost]
        public IActionResult MostrarListaSubastas()
        {

        }*/

        [HttpPost]
        public IActionResult CompraDePublicacion(Publicacion publicacion) 
        {
            try
            {
                if (HttpContext.Session.GetInt32("idUsuarioCliente") != null)
                {
                    int idUsuario = (int)HttpContext.Session.GetInt32("idUsuarioCliente");
                    Usuario usuario = Sistema.Instancia.BuscarUsuarioPorId(idUsuario);
                    if (usuario != null && publicacion != null && publicacion is PublicacionVenta)
                    {
                        UsuarioCliente usuarioCliente = (UsuarioCliente)usuario;
                        if (usuarioCliente.Saldo >= publicacion.Precio)
                        {
                            DateTime fechaFinalizada = DateTime.Now;

                           /* Sistema.Instancia.CobrarSaldoAUsuarioCliente(usuarioCliente, publicacion.Precio);*/
                           
                            
                        }
                    }

                }
            }
            catch (Exception ex) { }
            
            return View();
        }

       
    }
}
