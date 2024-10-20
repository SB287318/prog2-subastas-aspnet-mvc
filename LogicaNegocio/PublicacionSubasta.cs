namespace LogicaNegocio
{
    public class PublicacionSubasta : Publicacion
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

        public void AltaOferta(Usuario usuario, double monto, DateTime fecha)
        {
            try
            {

                Oferta oferta = new Oferta(usuario, monto, fecha);
                oferta.Validar();
                if (!_ofertas.Contains(oferta))
                {
                    _ofertas.Add(oferta);
                }
            }
            catch { }
        }
    }
}
