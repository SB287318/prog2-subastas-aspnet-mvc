using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class PublicacionVenta:Publicacion
    {
        private bool _ofertaRelampago;

        //Constructor

        public PublicacionVenta(string nombre, string estado, DateTime fechaPublicacion, bool ofertaRelampago) : base(nombre, estado, fechaPublicacion)
        {
            _ofertaRelampago = ofertaRelampago;
        }
    }
}
