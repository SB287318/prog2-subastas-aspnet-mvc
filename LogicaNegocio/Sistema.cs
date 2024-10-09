namespace LogicaNegocio
{
    public class Sistema
    {
        private List<Usuario> _usuarios = new List<Usuario>();
        private List<Articulo> _articulos = new List<Articulo>();
        private List<Publicacion> _publicaciones = new List<Publicacion>();

        /// <summary>
        /// Constructor
        /// </summary>
        public Sistema()
        {
            PrecargarUsuarios();
            PrecargarUsuariosCliente();
            PrecargarArticulos();
            PrecargarPublicacionesVenta();
        }

        /// <summary>
        /// Precargas y Altas
        /// </summary>

        private void PrecargarUsuarios()
        {
            AltaUsuario(new Usuario("Sofía", "Méndez", "sofia.mendez@example.com", "password123"));
            AltaUsuario(new Usuario("Gabriel", "Castro", "gabriel.castro@example.com", "password123"));
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

        private void PrecargarUsuariosCliente()
        {
            AltaUsuarioCliente(new UsuarioCliente("Juan", "Pérez", "juan.perez@example.com", "password123", 1000.50));
            AltaUsuarioCliente(new UsuarioCliente("María", "González", "maria.gonzalez@example.com", "password123", 1500.75));
            AltaUsuarioCliente(new UsuarioCliente("Carlos", "Rodríguez", "carlos.rodriguez@example.com", "password123", 2000.00));
            AltaUsuarioCliente(new UsuarioCliente("Lucía", "Fernández", "lucia.fernandez@example.com", "password123", 500.20));
            AltaUsuarioCliente(new UsuarioCliente("Pedro", "Martínez", "pedro.martinez@example.com", "password123", 750.10));
            AltaUsuarioCliente(new UsuarioCliente("Ana", "López", "ana.lopez@example.com", "password123", 1200.85));
            AltaUsuarioCliente(new UsuarioCliente("José", "García", "jose.garcia@example.com", "password123", 3000.00));
            AltaUsuarioCliente(new UsuarioCliente("Laura", "Sánchez", "laura.sanchez@example.com", "password123", 1800.30));
            AltaUsuarioCliente(new UsuarioCliente("Miguel", "Hernández", "miguel.hernandez@example.com", "password123", 2500.75));
            AltaUsuarioCliente(new UsuarioCliente("Carmen", "Díaz", "carmen.diaz@example.com", "password123", 950.45));
        }

        public void AltaUsuarioCliente(UsuarioCliente usuarioCliente)
        {
            try
            {
                usuarioCliente.Validar();
                _usuarios.Add(usuarioCliente);
            }
            catch (Exception ex)
            {
            }
        }

        private void PrecargarArticulos()
        {
            AltaArticulo(new Articulo("Laptop", "Electrónica", 1500.99));
            AltaArticulo(new Articulo("Smartphone", "Electrónica", 899.99));
            AltaArticulo(new Articulo("Cámara Digital", "Fotografía", 450.50));
            AltaArticulo(new Articulo("Televisor 4K", "Electrónica", 1200.75));
            AltaArticulo(new Articulo("Auriculares", "Accesorios", 75.30));
            AltaArticulo(new Articulo("Reloj Inteligente", "Accesorios", 199.99));
            AltaArticulo(new Articulo("Teclado Mecánico", "Periféricos", 150.00));
            AltaArticulo(new Articulo("Mouse Gamer", "Periféricos", 50.25));
            AltaArticulo(new Articulo("Impresora Láser", "Oficina", 300.00));
            AltaArticulo(new Articulo("Tablet", "Electrónica", 350.75));
            AltaArticulo(new Articulo("Bicicleta", "Deportes", 800.00));
            AltaArticulo(new Articulo("Patineta Eléctrica", "Deportes", 550.00));
            AltaArticulo(new Articulo("Silla Gamer", "Muebles", 250.50));
            AltaArticulo(new Articulo("Escritorio", "Muebles", 150.75));
            AltaArticulo(new Articulo("Lámpara de Escritorio", "Iluminación", 40.99));
            AltaArticulo(new Articulo("Colchón", "Muebles", 300.25));
            AltaArticulo(new Articulo("Sofá", "Muebles", 700.50));
            AltaArticulo(new Articulo("Zapatillas Deportivas", "Ropa", 120.00));
            AltaArticulo(new Articulo("Camiseta", "Ropa", 20.99));
            AltaArticulo(new Articulo("Chaqueta", "Ropa", 75.50));
            AltaArticulo(new Articulo("Pantalones", "Ropa", 45.25));
            AltaArticulo(new Articulo("Bolso", "Accesorios", 60.00));
            AltaArticulo(new Articulo("Gorra", "Accesorios", 15.50));
            AltaArticulo(new Articulo("Cinturón", "Accesorios", 25.00));
            AltaArticulo(new Articulo("Lentes de Sol", "Accesorios", 50.75));
            AltaArticulo(new Articulo("Juego de Ollas", "Cocina", 120.00));
            AltaArticulo(new Articulo("Cuchillos de Cocina", "Cocina", 70.99));
            AltaArticulo(new Articulo("Licuadora", "Cocina", 80.50));
            AltaArticulo(new Articulo("Tostadora", "Cocina", 30.75));
            AltaArticulo(new Articulo("Microondas", "Electrodomésticos", 150.25));
            AltaArticulo(new Articulo("Aspiradora", "Electrodomésticos", 200.00));
            AltaArticulo(new Articulo("Ventilador", "Electrodomésticos", 60.50));
            AltaArticulo(new Articulo("Lavadora", "Electrodomésticos", 500.99));
            AltaArticulo(new Articulo("Secadora", "Electrodomésticos", 450.50));
            AltaArticulo(new Articulo("Refrigerador", "Electrodomésticos", 900.75));
            AltaArticulo(new Articulo("Cafetera", "Cocina", 100.25));
            AltaArticulo(new Articulo("Tetera", "Cocina", 40.50));
            AltaArticulo(new Articulo("Planchita de Pelo", "Belleza", 50.99));
            AltaArticulo(new Articulo("Secador de Pelo", "Belleza", 70.75));
            AltaArticulo(new Articulo("Espejo de Maquillaje", "Belleza", 30.99));
            AltaArticulo(new Articulo("Perfume", "Belleza", 120.00));
            AltaArticulo(new Articulo("Juego de Toallas", "Hogar", 40.25));
            AltaArticulo(new Articulo("Sábanas", "Hogar", 60.75));
            AltaArticulo(new Articulo("Cortinas", "Hogar", 45.50));
            AltaArticulo(new Articulo("Alfombra", "Hogar", 80.99));
            AltaArticulo(new Articulo("Reloj de Pared", "Decoración", 25.75));
            AltaArticulo(new Articulo("Cuadro Decorativo", "Decoración", 60.50));
            AltaArticulo(new Articulo("Florero", "Decoración", 20.99));
            AltaArticulo(new Articulo("Planta Artificial", "Decoración", 15.75));
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

        private void PrecargarPublicacionesVenta()
        {
            try
            {

                AltaPublicacionVenta(new PublicacionVenta("Electroparaiso", "ABIERTA", new DateTime(2024, 10, 01), BuscarArticulo(1), false));
                AgregarArticuloAPublicacion(1, 2);

                AltaPublicacionVenta(new PublicacionVenta("Momento GAMER", "ABIERTA", new DateTime(2024, 10, 02), BuscarArticulo(8), true));
                AgregarArticuloAPublicacion(2, 13);

                AltaPublicacionVenta(new PublicacionVenta("Transporte", "ABIERTA", new DateTime(2024, 10, 03), BuscarArticulo(11), false));
                AgregarArticuloAPublicacion(3, 12);


                AltaPublicacionVenta(new PublicacionVenta("Muebles", "ABIERTA", new DateTime(2024, 10, 04), BuscarArticulo(14), true));
                AgregarArticuloAPublicacion(4, 16);
                AgregarArticuloAPublicacion(4, 17);


                AltaPublicacionVenta(new PublicacionVenta("A la moda", "ABIERTA", new DateTime(2024, 10, 05), BuscarArticulo(18), false));
                AgregarArticuloAPublicacion(5, 19);
                AgregarArticuloAPublicacion(5, 20);
                AgregarArticuloAPublicacion(5, 21);


                AltaPublicacionVenta(new PublicacionVenta("Accesorios", "ABIERTA", new DateTime(2024, 10, 06), BuscarArticulo(22), true));
                AgregarArticuloAPublicacion(6, 23);
                AgregarArticuloAPublicacion(6, 24);
                AgregarArticuloAPublicacion(6, 25);

                AltaPublicacionVenta(new PublicacionVenta("Cocina", "ABIERTA", new DateTime(2024, 10, 07), BuscarArticulo(26), false));
                AgregarArticuloAPublicacion(7, 27);

                AltaPublicacionVenta(new PublicacionVenta("Desalluno", "ABIERTA", new DateTime(2024, 10, 08), BuscarArticulo(28), true));
                AgregarArticuloAPublicacion(8, 29);

                AltaPublicacionVenta(new PublicacionVenta("Electrodomesticos", "ABIERTA", new DateTime(2024, 10, 09), BuscarArticulo(30), false));
                AgregarArticuloAPublicacion(9, 31);
                AgregarArticuloAPublicacion(9, 32);
                AgregarArticuloAPublicacion(9, 33);
                AgregarArticuloAPublicacion(9, 34);
                AgregarArticuloAPublicacion(9, 35);

                AltaPublicacionVenta(new PublicacionVenta("Bellizimo", "ABIERTA", new DateTime(2024, 10, 10), BuscarArticulo(38), true));
                AgregarArticuloAPublicacion(10, 39);
                AgregarArticuloAPublicacion(10, 40);
            }
            catch { }
        }


        public void AltaPublicacionVenta(PublicacionVenta publicacionVenta)
        {
            try
            {
                publicacionVenta.Validar();
                _publicaciones.Add(publicacionVenta);
            }
            catch { }
        }

        private void PrecargarPublicacionesSubasta()
        {

        }

        public void AltaPublicacionSubasta(PublicacionSubasta publicacionSubasta)
        {
            try
            {
                publicacionSubasta.Validar();
                _publicaciones.Add(publicacionSubasta);
            }
            catch { }
        }

        /// <summary>
        /// Agrega Articulo a Publicacion
        /// </summary>
        /// <param name="idPublicacion"></param>
        /// <param name="idArticulo"></param>

        private void AgregarArticuloAPublicacion(int idPublicacion, int idArticulo)
        {
            Publicacion publicacion = BuscarPublicacion(idPublicacion);
            Articulo articulo = BuscarArticulo(idArticulo);
            try
            {
                if (publicacion != null && articulo != null && !publicacion.ContieneArticulo(articulo))
                {
                    publicacion.AgregarArticulo(articulo);
                }
            }
            catch { }
        }

        /// <summary>
        /// Busca y devuelve un Articulo de _articulos por su Id
        /// </summary>
        /// <param name="idArticulo"></param>
        /// <returns></returns>

        public Articulo BuscarArticulo(int idArticulo)
        {
            Articulo articuloBuscado = null;
            foreach (Articulo articulo in _articulos)
            {

                if (articulo.Id == idArticulo)
                {
                    articuloBuscado = articulo;
                }
            }
            return articuloBuscado;
        }

        /// <summary>
        /// Busca y devuelve una Publicacion en _pulicaciones segun un Id
        /// </summary>
        /// <param name="idPublicacion"></param>
        /// <returns></returns>

        public Publicacion BuscarPublicacion(int idPublicacion)
        {
            Publicacion publicacionBuscada = null;
            foreach (Publicacion publicacion in _publicaciones)
            {

                if (publicacion.Id == idPublicacion)
                {
                    publicacionBuscada = publicacion;
                }
            }
            return publicacionBuscada;
        }
    }
}
