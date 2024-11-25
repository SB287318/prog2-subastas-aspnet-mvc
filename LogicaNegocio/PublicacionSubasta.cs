namespace LogicaNegocio
{
    public class PublicacionSubasta : Publicacion
    {
        private List<Oferta> _ofertas = new List<Oferta>();
        private double _precio;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="estado"></param>
        /// <param name="fechaPublicacion"></param>

        public PublicacionSubasta(string nombre, string estado, DateTime fechaPublicacion, Articulo articulo) : base(nombre, estado, fechaPublicacion, articulo)
        {
        }

        public double Precio 
        { 
            get { return _precio; } 
        }

        /// <summary>
        /// Agregar oferta
        /// </summary>
        /// <param name="oferta"></param>

        public void AltaOferta(UsuarioCliente usuarioCliente, double monto, DateTime fecha)
        {
            Oferta oferta = new Oferta(usuarioCliente, monto, fecha);
            oferta.Validar();
            if (!_ofertas.Contains(oferta))
            {
                _ofertas.Add(oferta);
            }
        }

        public override void CalcularPrecio()
        {
            _ofertas.Sort();
            _precio = _ofertas[0].Monto;
        }
    }
}
