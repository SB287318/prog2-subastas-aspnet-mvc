using LogicaNegocio.Interface;

namespace LogicaNegocio
{
    public class Articulo : IValidate, IEquatable<Articulo>
    {
        private int _id;
        private static int s_ultId = 1;
        private string _nombre;
        private string _categoria;
        private double _precioVenta;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="categoria"></param>
        /// <param name="precioVenta"></param>
        public Articulo(string nombre, string categoria, double precioVenta)
        {
            _nombre = nombre;
            _categoria = categoria;
            _precioVenta = precioVenta;
            _id = Articulo.s_ultId;
            Articulo.s_ultId++;
        }

        /// <summary>
        /// Accesores
        /// </summary>

        public int Id
        { 
            get { return _id; } 
        }

        public string Categoria
        {
            get { return _categoria; }
        }

        public override string ToString() 
        {
            return "Id: " + _id + "\nNombre: " + _nombre + "\nPrecio de venta: " + _precioVenta;
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
            if (string.IsNullOrEmpty(_categoria))
            {
                throw new Exception("La categoria es obligatoria");
            }
            if (_precioVenta <= 0)
            {
                throw new Exception("El precio de venta debe ser mayor a 0");
            }
        }

        public bool Equals(Articulo? other)
        {
            return _id == other._id;
        }
    }
}
