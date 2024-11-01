using LogicaNegocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Oferta : IValidate, IEquatable<Oferta>
    {
        private int _id;
        private static int s_ultId;
        private Usuario _usuario;
        private double _monto;
        private DateTime _fecha;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="monto"></param>
        /// <param name="fecha"></param>

        public Oferta(Usuario usuario, double monto, DateTime fecha) { 
            _usuario = usuario;
            _monto = monto;
            _fecha = fecha;
        }

        /// <summary>
        /// Validacion
        /// </summary>
        /// <exception cref="Exception"></exception>

        public void Validar()
        {
            if (_usuario == null)
            {
                throw new Exception("El usuario es obligatorio");
            }
        }

        public bool Equals(Oferta? other)
        {
            return _usuario == other._usuario && _fecha == other._fecha;
        }
    }

}
