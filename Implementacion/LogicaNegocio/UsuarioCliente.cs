using LogicaNegocio.Interface;

namespace LogicaNegocio
{
    public class UsuarioCliente : Usuario, IValidate
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
        /// Accesores
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "[" + Id + "] - " + Nombre + " " + Apellido;
        }

        public double Saldo
        {
            get { return _saldoDisponible; }
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

        /// <summary>
        /// Carga saldo
        /// </summary>
        /// <param name="montoACargar"></param>
        public void CargarSaldo(double montoACargar)
        {
            _saldoDisponible += montoACargar;
        }

        public void CobrarSaldo(double montoACobrar)
        {
            _saldoDisponible -= montoACobrar;
        }
    }
}
