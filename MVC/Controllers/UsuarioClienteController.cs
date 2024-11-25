using LogicaNegocio;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class UsuarioClienteController : Controller
    {
        private Sistema sistema = Sistema.Instancia;

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string nombre, string apellido, string email, string contraseña, double saldoDisponible)
        {
            try
            {
                if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(contraseña) && contraseña.Count() >= 8 && saldoDisponible >= 0)
                {
                    sistema.AltaUsuarioCliente(nombre, apellido, email, contraseña, saldoDisponible);
                    ViewBag.Mensaje = "El usuario fue creado correctamente";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;
            }
            return View();
        }
    }
}
