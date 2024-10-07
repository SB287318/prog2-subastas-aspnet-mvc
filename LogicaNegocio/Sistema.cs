using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    internal class Sistema
    {
        private List<Usuario> _usuarios = new List<Usuario>();
        private List<Articulo> _articulos = new List<Articulo>();
        private List<Publicacion> _publicaciones = new List<Publicacion>();
        private List<Oferta> _ofertas = new List<Oferta>();



        public void AltaUsuario(Usuario usuario)
        {
            //valida datos
            //si es valido agregar a lista
        }

        public void PrecargarUsuarios() {
            AltaUsuario(new Usuario());
        }

        public void AltaArticulo(Articulo articulo)
        {

        }

        public void PrecargaArticulos()
        {
            AltaArticulo(new Articulo());
        }

        public void AltaPublicacion(Publicacion publicacion)
        {

        }

        public void PrecargaPublicaciones()
        {
            AltaPublicacion(new Publicacion());
        }

        public void AltaOferta(Oferta oferta)
        {

        }

        public void PrecargaOfertas()
        {
            AltaOferta(new Oferta());
        }

    }
}
