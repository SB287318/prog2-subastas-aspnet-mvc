using LogicaNegocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public abstract class Publicacion : IValidate
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

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="estado"></param>
        /// <param name="fechaPublicacion"></param>

        public Publicacion(string nombre, string estado, DateTime fechaPublicacion)
        {
            _nombre = nombre;
            _estado = estado;
            _fechaPublicacion = fechaPublicacion;
            _id = Publicacion.s_ultId;
            Publicacion.s_ultId++;
        }

        /// <summary>
        /// Añadir articulos
        /// </summary>
        /// <param name="articulo"></param>

        public void AgregarArticulo(Articulo articulo)
        {
            _articulos.Add(articulo);
        }

        /// <summary>
        /// Validacion
        /// </summary>
        /// <exception cref="Exception"></exception>

        public void Validar()
        {
            if (string.IsNullOrEmpty(_nombre))
            {
                throw new Exception("El nombre es obligatorio");
            }
            if (string.IsNullOrEmpty(_estado))
            {
                throw new Exception("El estado es obligatorio");
            }
            if (_fechaPublicacion <= DateTime.MinValue)
            {
                throw new Exception("La fecha de publicacion es obligatoria");
            }
        }
    }
}
