using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    internal abstract class Publicacion
    {
        private int _id;
        private static int s_ultId;
        private string _nombre;
        private string _estado;
        private DateTime _fechaPublicacion;
        private List<Articulo> _articulos = new List<Articulo>();
        private UsuarioCliente _usuarioClienteComprador;
        private Usuario _usuarioFinalizador;
        private DateTime _fechaFinalizada;
    }
}
