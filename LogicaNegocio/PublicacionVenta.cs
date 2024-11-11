using LogicaNegocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class PublicacionVenta : Publicacion
    {
        private bool _ofertaRelampago;
        private double _precio;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="estado"></param>
        /// <param name="fechaPublicacion"></param>
        /// <param name="ofertaRelampago"></param>

        public PublicacionVenta(string nombre, string estado, DateTime fechaPublicacion, Articulo articulo, bool ofertaRelampago) : base(nombre, estado, fechaPublicacion, articulo)
        {
            _ofertaRelampago = ofertaRelampago;
            _precio = this.CalcularPrecio();
        }

        /// <summary>
        /// Calcula y devuelve el precio de la PublicacionVenta
        /// </summary>
        /// <returns></returns>

        public override double CalcularPrecio() 
        {
            double precio = 0;
            foreach (Articulo articulo in Articulos) 
            {
                precio += articulo.PrecioVenta;
            }

            if (_ofertaRelampago)
            {
                precio -= precio *0.20;
            }
            return precio;
        }
    }
}
