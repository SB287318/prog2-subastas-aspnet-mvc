namespace LogicaNegocio
{
    public class PublicacionSubasta : Publicacion, IComparable<PublicacionSubasta>
    {
        private List<Oferta> _ofertas = new List<Oferta>();

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="estado"></param>
        /// <param name="fechaPublicacion"></param>

        public PublicacionSubasta(string nombre, string estado, DateTime fechaPublicacion, Articulo articulo) : base(nombre, estado, fechaPublicacion, articulo)
        {
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
            if (_ofertas.Count() > 0)
            {
                _ofertas.Sort();
                Precio = _ofertas[0].Monto;
            }
        }

        public int CompareTo(PublicacionSubasta? other)
        {
            return FechaPublicacion.CompareTo(other.FechaPublicacion) * -1;
        }
    }
}
