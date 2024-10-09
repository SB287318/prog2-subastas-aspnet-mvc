namespace LogicaNegocio
{
    public class Sistema
    {
        private List<Usuario> _usuarios = new List<Usuario>();
        private List<Articulo> _articulos = new List<Articulo>();
        private List<Publicacion> _publicaciones = new List<Publicacion>();

        //Constructor
        public Sistema()
        {
            PrecargarUsuarios();
        }

        //Precargas y Altas

        private void PrecargarUsuarios()
        {
            AltaUsuario(new Usuario());
        }

        public void AltaUsuario(Usuario usuario)
        {
            try
            {
                usuario.Validar();
                _usuarios.Add(usuario);
            }
            catch (Exception ex)
            {
            }
        }

        public void PrecargarArticulos()
        {
            AltaArticulo(new Articulo());
        }

        public void AltaArticulo(Articulo articulo)
        {
            try
            {
                articulo.Validar();
                _articulos.Add(articulo);
            }
            catch (Exception ex) { }
           
        }

        public void PrecargarPublicaciones()
        {
            AltaPublicacionVenta(new PublicacionVenta());
        }


        public void AltaPublicacionVenta(PublicacionVenta publicacionVenta)
        {
            publicacionVenta.Validar();
            _publicaciones.Add(publicacionVenta);
        }

       
    }
}
