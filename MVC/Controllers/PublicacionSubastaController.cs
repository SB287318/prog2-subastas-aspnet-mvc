using LogicaNegocio;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class PublicacionSubastaController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                int idUsuario = (int)HttpContext.Session.GetInt32("idUsuarioCliente");
                Usuario usuario = Sistema.Instancia.BuscarUsuarioPorId(idUsuario);
                if (HttpContext.Session.GetInt32("idUsuarioCliente") != null && usuario != null && usuario is not UsuarioCliente)
                {
                    ViewBag.ListaPublicacionesSubasta = Sistema.Instancia.Publicaciones;
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
