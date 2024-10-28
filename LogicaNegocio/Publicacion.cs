using LogicaNegocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public abstract class Publicacion : IValidate, IEquatable<Publicacion> 
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

        public Publicacion(string nombre, string estado, DateTime fechaPublicacion, Articulo articulo)
        {
            _nombre = nombre;
            _estado = estado;
            _fechaPublicacion = fechaPublicacion;
            _articulos.Add(articulo);
            _id = Publicacion.s_ultId;
            Publicacion.s_ultId++;
        }

        /// <summary>
        /// Accesores
        /// </summary>

        public int Id
        {
            get { return _id; }
        }

        public DateTime FechaPublicacion
        {
            get { return _fechaPublicacion; }
        }

        public override string ToString()
        {
            return "Id: "+ _id + "\nNombre: " + _nombre + "\nEstado: " + _estado + "\nFecha de Publicación: " + _fechaPublicacion + "\n";
        }

        /// <summary>
        /// Agregar articulos
        /// </summary>
        /// <param name="articulo"></param>

        public void AgregarArticulo(Articulo articulo)
        {
            _articulos.Add(articulo);
        }

        /// <summary>
        /// Devuelve True o False segun si el Articulo esta en la Publicacion
        /// </summary>
        /// <param name="articulo"></param>
        /// <returns></returns>

        public bool ContieneArticulo(Articulo articulo)
        {
            bool resultado = false;
            if (_articulos.Contains(articulo))
            {
                resultado = true;
            }
            return resultado;
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
            if (_articulos == null)
            {
                throw new Exception("El articulo es obligatorio");
            }
        }

        public bool Equals(Publicacion? other)
        {
            return _nombre == other._nombre;
        }
    }
}
