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
                else
                {
                    ViewBag.Mensaje = "El usuario no pudo ser creado";
                }
            }
            catch (Exception ex)
            {
                ViewBag.Mensaje = ex.Message;
            }
            return View();
        }

        /// <summary>
        /// Muestra la pagina para cargar saldo
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult BilleteraElectronica()
        {
            try
            {
                int idUsuario = (int)HttpContext.Session.GetInt32("idUsuarioCliente");
                Usuario usuario = Sistema.Instancia.BuscarUsuarioPorId(idUsuario);
                if (HttpContext.Session.GetInt32("idUsuarioCliente") != null && usuario != null && usuario is UsuarioCliente)
                {
                    UsuarioCliente usuarioCliente = (UsuarioCliente)usuario;
                    ViewBag.SaldoUsuarioCliente = usuarioCliente.Saldo;
                    return View();
                }
            }
            catch (Exception ex)
            {

            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult BilleteraElectronica(double montoACargar)
        {
            try
            {
                if (montoACargar > 0)
                {
                    int idUsuario = (int)HttpContext.Session.GetInt32("idUsuarioCliente");
                    Usuario usuario = Sistema.Instancia.BuscarUsuarioPorId(idUsuario);
                    if (HttpContext.Session.GetInt32("idUsuarioCliente") != null && usuario != null && usuario is UsuarioCliente)
                    {
                        UsuarioCliente usuarioCliente = (UsuarioCliente)usuario;
                        Sistema.Instancia.CargarSaldoAUsuarioCliente(usuarioCliente, montoACargar);
                        ViewBag.SaldoUsuarioCliente = usuarioCliente.Saldo;
                        ViewBag.Mensaje = "Se cargo saldo exitosamente";
                        return View();
                    }
                }
                else
                {
                    int idUsuario = (int)HttpContext.Session.GetInt32("idUsuarioCliente");
                    Usuario usuario = Sistema.Instancia.BuscarUsuarioPorId(idUsuario);
                    UsuarioCliente usuarioCliente = (UsuarioCliente)usuario;
                    ViewBag.SaldoUsuarioCliente = usuarioCliente.Saldo;
                    ViewBag.Mensaje = "Los datos no son correctos";
                }
            }
            catch (Exception ex) { }
            return View();
        }
    }
}
