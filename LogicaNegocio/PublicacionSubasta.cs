using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class PublicacionSubasta : Publicacion
    {
        private List<Oferta> _ofertas = new List<Oferta>();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="estado"></param>
        /// <param name="fechaPublicacion"></param>

        public PublicacionSubasta(string nombre, string estado, DateTime fechaPublicacion, Articulo articulo) : base(nombre, estado, fechaPublicacion, articulo)
        {
        }

        /// <summary>
        /// Agregar ofertas
        /// </summary>
        /// <param name="oferta"></param>

        public void AgregarOferta(Oferta oferta)
        {
            _ofertas.Add(oferta);
        }
    }
}
