using LogicaNegocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Oferta : IValidate, IEquatable<Oferta>, IComparable<Oferta>
    {
        private int _id;
        private static int s_ultId = 1;
        private UsuarioCliente _usuarioCliente;
        private double _monto;
        private DateTime _fecha;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="monto"></param>
        /// <param name="fecha"></param>

        public Oferta(UsuarioCliente usuarioCliente, double monto, DateTime fecha) {
            _usuarioCliente = usuarioCliente;
            _monto = monto;
            _fecha = fecha;
            _id = s_ultId;
            Oferta.s_ultId++;
        }

        public double Monto 
        { 
            get { return _monto; } 
        }

        /// <summary>
        /// Validacion
        /// </summary>
        /// <exception cref="Exception"></exception>

        public void Validar()
        {
            if (_usuarioCliente == null)
            {
                throw new Exception("El usuario es obligatorio");
            }
        }

        public bool Equals(Oferta? other)
        {
            return _usuarioCliente == other._usuarioCliente && _fecha == other._fecha;
        }

        public int CompareTo(Oferta? other)
        {
            return _monto.CompareTo(other._monto)*-1;
        }
    }

}
