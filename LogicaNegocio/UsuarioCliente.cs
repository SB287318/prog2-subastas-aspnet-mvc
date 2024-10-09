using LogicaNegocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class UsuarioCliente : Usuario , IValidate
    {
        private double _saldoDisponible;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="email"></param>
        /// <param name="contraseña"></param>
        /// <param name="saldoDisponible"></param>

        public UsuarioCliente(string nombre, string apellido, string email, string contraseña, double saldoDisponible) : base(nombre, apellido, email, contraseña)
        {
            _saldoDisponible = saldoDisponible;
        }

        /// <summary>
        /// Validacion
        /// </summary>
        /// <exception cref="Exception"></exception>

        public void Validar() 
        {
            base.Validar();

            if (_saldoDisponible < 0)
            {
                throw new Exception("El saldo debe tener un minimo de 0");
            }
        }
    }
}
