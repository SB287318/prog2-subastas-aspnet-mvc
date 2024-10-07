using LogicaNegocio.Interface;

namespace LogicaNegocio
{
    public class Articulo : IValidate
    {
        private int _id;
        private static int s_ultId = 1;
        private string _nombre;
        private string _categoria;
        private double _precioVenta;

        ///Constructor///
        public Articulo(string nombre, string categoria, double precioVenta)
        {
            _nombre = nombre;
            _categoria = categoria;
            _precioVenta = precioVenta;
            _id = Articulo.s_ultId;
            Articulo.s_ultId++;
        }

        /// Validacion de datos 
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

        public override bool Equals(object? obj)
        {
            bool sonIguales = false;
            if (obj!=null && obj is Articulo)
            {
                Articulo articulo = (Articulo)obj;
            }            
            return true;
        }
    }
}
