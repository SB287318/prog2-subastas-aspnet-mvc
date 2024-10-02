using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    internal class Usuario
    {
        private int _id;
        private static int s_ultId = 1;
        private string _nombre;
        private string _apellido;
        private string _email;
        private string _contraseña;

        public Usuario(string nombre, string apellido, string email, string contraseña) {
            _nombre = nombre;
            _apellido = apellido;
            _email = email;
            _contraseña = contraseña;
            _id =Usuario.s_ultId;
            Usuario.s_ultId++;

        }

    }
}
