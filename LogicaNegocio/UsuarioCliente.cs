using LogicaNegocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class UsuarioCliente : Usuario
    {
        private double _saldoDisponible;

        public UsuarioCliente(string nombre, string apellido, string email, string contraseña, double saldoDisponible) : base(nombre, apellido, email, contraseña)
        {
            _saldoDisponible = saldoDisponible;
        }
    }
}
