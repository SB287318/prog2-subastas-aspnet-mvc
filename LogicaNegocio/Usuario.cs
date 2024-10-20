using LogicaNegocio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Usuario : IValidate, IEquatable<Usuario>
    {
        private int _id;
        private static int s_ultId = 1;
        private string _nombre;
        private string _apellido;
        private string _email;
        private string _contraseña;

        /// <summary>
        /// Contsructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="email"></param>
        /// <param name="contraseña"></param>

        public Usuario(string nombre, string apellido, string email, string contraseña) {
            _nombre = nombre;
            _apellido = apellido;
            _email = email;
            _contraseña = contraseña;
            _id =Usuario.s_ultId;
            Usuario.s_ultId++;

        }

        /// <summary>
        /// Accesores
        /// </summary>

        public int Id
        {
            get { return _id; }
        }

        public string Nombre
        {
            get { return _nombre; }
        }
        public string Apellido
        {
            get { return _apellido; }
        }


        /// <summary>
        /// Validacion
        /// </summary>
        /// <exception cref="Exception"></exception>

        public void Validar()
        {
            if (string.IsNullOrEmpty(_nombre))
            {
                throw new Exception("El nombre es obligatorio");
            }
            if (string.IsNullOrEmpty(_apellido))
            {
                throw new Exception("El apellido es obligatorio");
            }
            if (string.IsNullOrEmpty(_email))
            {
                throw new Exception("El email es obligatorio");
            }
            if (string.IsNullOrEmpty(_contraseña))
            {
                throw new Exception("La contraseña es obligatoria");
            }
        }

        public bool Equals(Usuario? other)
        {
            return _id == other._id;
        }
    }
}
