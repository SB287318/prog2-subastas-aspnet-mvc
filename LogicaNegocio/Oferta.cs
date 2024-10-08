using LogicaNegocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Oferta:IValidate
    {
        private int _id;
        private static int s_ultId;
        private Usuario _usuario;
        private double _monto;
        private DateTime _fecha;

        //Constructor

        public Oferta(Usuario usuario, double monto, DateTime fecha) { 
            _usuario = usuario;
            _monto = monto;
            _fecha = fecha;
        }

        public void Validar()
        {
            if (_usuario != null && _usuario is Usuario)
            {
                
            }
        }
    }

}
