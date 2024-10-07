using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class PublicacionSubasta:Publicacion
    {
        private List<Oferta> _ofertas = new List<Oferta>();

        //Constructor

        public PublicacionSubasta(string nombre, string estado, DateTime fechaPublicacion) : base(nombre, estado, fechaPublicacion)
        {
        }

        public void AgregarOferta(Oferta oferta)
        {
            _ofertas.Add(oferta);
        }
    }
}
