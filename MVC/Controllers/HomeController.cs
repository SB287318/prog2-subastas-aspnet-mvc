using LogicaNegocio;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Diagnostics;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string contraseña)
        {
            try
            {
                if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(contraseña))
                {
                    Usuario usuario = Sistema.Instancia.BuscarUsuarioPorEmailYContraseña(email, contraseña);
                    if (usuario != null)
                    {
                        if (usuario is UsuarioCliente)
                        {
                            HttpContext.Session.SetInt32("idUsuarioCliente", usuario.Id);
                            return RedirectToAction("Index", "Publicacion");
                        }
                        else
                        {
                            HttpContext.Session.SetInt32("idUsuarioAdmin", usuario.Id);
                            return RedirectToAction("MostrarListaSubastas", "Publicacion");
                        }
                    }
                    else
                    {
                        ViewBag.Mensaje = "Los datos no son correctos";
                    }
                }
                else
                {
                    ViewBag.Mensaje = "Los datos no son correctos";
                }
            }
            catch (Exception ex)
            {

            }

            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
