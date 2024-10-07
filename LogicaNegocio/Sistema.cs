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

        //Precargas y Altas

        public void AltaUsuario(Usuario usuario)
        {
            //valida datos
            //si es valido agregar a lista
            usuario.Validar();
            _usuarios.Add(usuario);
        }

        public void PrecargarUsuarios() {
            AltaUsuario(new Usuario());
        }

        public void AltaArticulo(Articulo articulo)
        {
            articulo.Validar();
            _articulos.Add(articulo);
        }

        public void PrecargaArticulos()
        {
            AltaArticulo(new Articulo());
        }

        public void AltaPublicacion(Publicacion publicacion)
        {
            publicacion.Validar();
            _publicaciones.Add(publicacion);
        }

        public void PrecargaPublicaciones()
        {
            AltaPublicacion(new Publicacion());
        }

    }
}
