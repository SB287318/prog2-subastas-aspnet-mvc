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
        }
    }
}
