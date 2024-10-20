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
            PrecargarPublicacionesSubasta();
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
                if (!_usuarios.Contains(usuario))
                {
                    usuario.Validar();
                    _usuarios.Add(usuario);
                }
            }
            catch
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
                if (!_usuarios.Contains(usuarioCliente))
                {
                    usuarioCliente.Validar();
                    _usuarios.Add(usuarioCliente);
                }
            }
            catch
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
                if (!_articulos.Contains(articulo))
                {
                    articulo.Validar();
                    _articulos.Add(articulo);
                }
            }
            catch
            {
            }

        }

        private void PrecargarPublicacionesVenta()
        {
            try
            {

                AltaPublicacionVenta(new PublicacionVenta("Electroparaiso", "ABIERTA", new DateTime(2024, 10, 01), BuscarArticulo(1), false));
                AgregarArticuloAPublicacion(1, 2);

                AltaPublicacionVenta(new PublicacionVenta("Fotogenico", "ABIERTA", new DateTime(2024, 10, 02), BuscarArticulo(3), true));
                AgregarArticuloAPublicacion(2, 4);

                AltaPublicacionVenta(new PublicacionVenta("Accesorio Inteligente", "ABIERTA", new DateTime(2024, 10, 03), BuscarArticulo(5), false));
                AgregarArticuloAPublicacion(3, 6);


                AltaPublicacionVenta(new PublicacionVenta("Periferico compu", "ABIERTA", new DateTime(2024, 10, 04), BuscarArticulo(7), true));
                AgregarArticuloAPublicacion(4, 8);


                AltaPublicacionVenta(new PublicacionVenta("Homeoffice", "ABIERTA", new DateTime(2024, 10, 05), BuscarArticulo(9), false));
                AgregarArticuloAPublicacion(5, 10);


                AltaPublicacionVenta(new PublicacionVenta("Transporte", "ABIERTA", new DateTime(2024, 10, 06), BuscarArticulo(11), true));
                AgregarArticuloAPublicacion(6, 12);

                AltaPublicacionVenta(new PublicacionVenta("Muebles", "ABIERTA", new DateTime(2024, 10, 07), BuscarArticulo(13), false));
                AgregarArticuloAPublicacion(7, 14);
                AgregarArticuloAPublicacion(7, 16);
                AgregarArticuloAPublicacion(7, 17);


                AltaPublicacionVenta(new PublicacionVenta("Ropa", "ABIERTA", new DateTime(2024, 10, 08), BuscarArticulo(18), true));
                AgregarArticuloAPublicacion(8, 19);
                AgregarArticuloAPublicacion(8, 20);
                AgregarArticuloAPublicacion(8, 21);


                AltaPublicacionVenta(new PublicacionVenta("A la moda", "ABIERTA", new DateTime(2024, 10, 09), BuscarArticulo(22), false));
                AgregarArticuloAPublicacion(9, 23);
                AgregarArticuloAPublicacion(9, 24);
                AgregarArticuloAPublicacion(9, 25);


                AltaPublicacionVenta(new PublicacionVenta("Cocina", "ABIERTA", new DateTime(2024, 10, 10), BuscarArticulo(26), true));
                AgregarArticuloAPublicacion(10, 27);
            }
            catch { }
        }


        public void AltaPublicacionVenta(PublicacionVenta publicacionVenta)
        {
            try
            {
                if (!_publicaciones.Contains(publicacionVenta))
                {
                    publicacionVenta.Validar();
                    _publicaciones.Add(publicacionVenta);
                }
            }
            catch
            {
            }
        }

        private void PrecargarPublicacionesSubasta()
        {
            try
            {
                AltaPublicacionSubasta(new PublicacionSubasta("Buena mañana", "ABIERTA", new DateTime(2024, 10, 01), BuscarArticulo(28)));
                AgregarArticuloAPublicacion(11, 29);


                AltaPublicacionSubasta(new PublicacionSubasta("Electrodomesticos", "ABIERTA", new DateTime(2024, 10, 02), BuscarArticulo(30)));
                AgregarArticuloAPublicacion(12, 32);


                AltaPublicacionSubasta(new PublicacionSubasta("Limpieza", "ABIERTA", new DateTime(2024, 10, 03), BuscarArticulo(31)));
                AgregarArticuloAPublicacion(13, 33);
                AgregarArticuloAPublicacion(13, 34);


                AltaPublicacionSubasta(new PublicacionSubasta("Mejora de cocina", "ABIERTA", new DateTime(2024, 10, 04), BuscarArticulo(35)));
                AgregarArticuloAPublicacion(14, 35);
                AgregarArticuloAPublicacion(14, 36);
                AgregarArticuloAPublicacion(14, 37);

                AltaPublicacionSubasta(new PublicacionSubasta("Para el pelo", "ABIERTA", new DateTime(2024, 10, 05), BuscarArticulo(39)));
                AgregarArticuloAPublicacion(15, 39);



                AltaPublicacionSubasta(new PublicacionSubasta("Belleza", "ABIERTA", new DateTime(2024, 10, 06), BuscarArticulo(40)));
                AgregarArticuloAPublicacion(16, 41);

                AltaPublicacionSubasta(new PublicacionSubasta("Hogar", "ABIERTA", new DateTime(2024, 10, 07), BuscarArticulo(42)));
                AgregarArticuloAPublicacion(17, 43);

                AltaPublicacionSubasta(new PublicacionSubasta("Decoracion", "ABIERTA", new DateTime(2024, 10, 08), BuscarArticulo(44)));
                AgregarArticuloAPublicacion(18, 45);

                AltaPublicacionSubasta(new PublicacionSubasta("Decoracion 2", "ABIERTA", new DateTime(2024, 10, 09), BuscarArticulo(46)));
                AgregarArticuloAPublicacion(19, 47);

                AltaPublicacionSubasta(new PublicacionSubasta("Decoracion 3", "ABIERTA", new DateTime(2024, 10, 10), BuscarArticulo(48)));
                AgregarArticuloAPublicacion(20, 49);

            }
            catch { }
        }

        public void AltaPublicacionSubasta(PublicacionSubasta publicacionSubasta)
        {
            try
            {
                if (!_publicaciones.Contains(publicacionSubasta))
                {
                    publicacionSubasta.Validar();
                    _publicaciones.Add(publicacionSubasta);
                }
            }
            catch
            {
            }
        }

        private void PrecargarOfertasAPublicacionesSubasta()
        {
            AgregarOfertaAPublicacionSubasta(15, BuscarUsuario(3), 950.45, new DateTime(2024, 10, 10));
            AgregarOfertaAPublicacionSubasta(15, BuscarUsuario(4), 1200.85, new DateTime(2024, 10, 06));
            AgregarOfertaAPublicacionSubasta(15, BuscarUsuario(5), 900.45, new DateTime(2024, 10, 08));
            AgregarOfertaAPublicacionSubasta(16, BuscarUsuario(6), 800.45, new DateTime(2024, 11, 08));
            AgregarOfertaAPublicacionSubasta(16, BuscarUsuario(7), 700.45, new DateTime(2024, 11, 13));
        }

        /// <summary>
        /// Agregar Oferta a PublicacionSubasta
        /// </summary>
        /// <param name="idPublicacion"></param>
        /// <param name="usuario"></param>
        /// <param name="monto"></param>
        /// <param name="fecha"></param>

        private void AgregarOfertaAPublicacionSubasta(int idPublicacion, Usuario usuario, double monto, DateTime fecha)
        {
            Publicacion publicacion = BuscarPublicacion(idPublicacion);
            if (publicacion != null && publicacion is PublicacionSubasta)
            {
                PublicacionSubasta publicacionSubasta = (PublicacionSubasta)publicacion;
                publicacionSubasta.AltaOferta(usuario, monto, fecha);
            }
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
            int cont = 0;
            while (articuloBuscado == null && cont < _articulos.Count)
            {
                if (_articulos[cont].Id == idArticulo)
                {
                    articuloBuscado = _articulos[cont];
                }
                cont++;
            }
            return articuloBuscado;
        }


        /// <summary>
        /// Busca y devuelve una Publicacion en _publicaciones segun un Id
        /// </summary>
        /// <param name="idPublicacion"></param>
        /// <returns></returns>

        public Publicacion BuscarPublicacion(int idPublicacion)
        {
            Publicacion publicacionBuscada = null;
            int cont = 0;
            while (publicacionBuscada == null && cont < _publicaciones.Count)
            {
                if (_publicaciones[cont].Id == idPublicacion)
                {
                    publicacionBuscada = _publicaciones[cont];
                }
                cont++;
            }
            return publicacionBuscada;
        }

        /// <summary>
        /// Buscar Usuario
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <returns></returns>
        public Usuario BuscarUsuario(int idUsuario)
        {
            Usuario usuarioBuscado = null;
            int cont = 0;
            while (usuarioBuscado == null && cont < _usuarios.Count)
            {
                if (_usuarios[cont].Id == idUsuario)
                {
                    usuarioBuscado = _usuarios[cont];
                }
                cont++;
            }
            return usuarioBuscado;
        }

        /// <summary>
        ///Metodo que devuelve Articulos de la Categoria dada 
        /// </summary>
        /// <param name="categoria"></param>
        /// <returns></returns>

        public List<Articulo> DevolverArticulosDeCategoriaDada(string categoria)
        {

            List<Articulo> listaArticulosFinal = new List<Articulo>();
            foreach (Articulo articulo in _articulos)
            {
                if (articulo.Categoria == categoria)
                {
                    listaArticulosFinal.Add(articulo);
                }
            }
            return listaArticulosFinal;
        }

        /// <summary>
        /// Metodo que devuelve a todos los clientes
        /// </summary>
        /// <returns></returns>

        public List<UsuarioCliente> DevolverTodosLosClientes()
        {
            List<UsuarioCliente> listaClientes = new List<UsuarioCliente>();
            foreach (Usuario usuario in _usuarios)
            {
                if (usuario != null && usuario is UsuarioCliente)
                {
                    UsuarioCliente usuarioCliente = (UsuarioCliente) usuario;
                    listaClientes.Add(usuarioCliente);
                }
            }
            return listaClientes;
        }

        /// <summary>
        /// Dado un nombre de categoría listar todos los artículos de esa categoría
        /// </summary>
        /// <param name="categoriaDada"></param>
        /// <returns></returns>
        public List<Articulo> DevolverListaArticulosConCategoria(string categoriaDada)
        {
            List<Articulo> listaArticulosConCategoria = new List<Articulo>();

            foreach (Articulo articulo in _articulos)
            {
                if (articulo.Categoria.Trim().ToUpper() == categoriaDada.Trim().ToUpper())
                {
                    listaArticulosConCategoria.Add(articulo);
                }
            }
            return listaArticulosConCategoria;
        }
    }
}
