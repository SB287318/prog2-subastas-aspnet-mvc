namespace LogicaNegocio
{
    public class Sistema
    {
        private List<Usuario> _usuarios = new List<Usuario>();
        private List<Articulo> _articulos = new List<Articulo>();
        private List<Publicacion> _publicaciones = new List<Publicacion>();
        // Patron singleton-1
        private static Sistema s_instancia;


        /// <summary>
        /// Accesores 
        /// </summary>

        // Patron singleton-2
        public static Sistema Instancia
        {
            get
            {
                if (s_instancia == null)
                {
                    s_instancia = new Sistema();
                }
                return s_instancia;
            }
        }

        /// <summary>
        /// Accesores
        /// </summary>
        public List<Publicacion> Publicaciones
        {
            get { return _publicaciones; }
        }


        /// <summary>
        /// Constructor
        /// </summary>
        private Sistema()
        {
            PrecargarUsuarios();
            PrecargarUsuariosCliente();
            PrecargarArticulos();
            PrecargarPublicacionesVenta();
            PrecargarPublicacionesSubasta();
            PrecargarOfertasAPublicacionesSubasta();
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
            usuario.Validar();
            if (!_usuarios.Contains(usuario))
            {
                _usuarios.Add(usuario);
            }
        }

        private void PrecargarUsuariosCliente()
        {
            AltaUsuarioCliente("Juan", "Pérez", "juan.perez@example.com", "password123", 1000.50);
            AltaUsuarioCliente("María", "González", "maria.gonzalez@example.com", "password123", 1500.75);
            AltaUsuarioCliente("Carlos", "Rodríguez", "carlos.rodriguez@example.com", "password123", 2000.00);
            AltaUsuarioCliente("Lucía", "Fernández", "lucia.fernandez@example.com", "password123", 500.20);
            AltaUsuarioCliente("Pedro", "Martínez", "pedro.martinez@example.com", "password123", 750.10);
            AltaUsuarioCliente("Ana", "López", "ana.lopez@example.com", "password123", 1200.85);
            AltaUsuarioCliente("José", "García", "jose.garcia@example.com", "password123", 3000.00);
            AltaUsuarioCliente("Laura", "Sánchez", "laura.sanchez@example.com", "password123", 1800.30);
            AltaUsuarioCliente("Miguel", "Hernández", "miguel.hernandez@example.com", "password123", 2500.75);
            AltaUsuarioCliente("Carmen", "Díaz", "carmen.diaz@example.com", "password123", 950.45);
        }

        public void AltaUsuarioCliente(string nombre, string apellido, string email, string contraseña, double saldoDisponible)
        {
            UsuarioCliente nuevoUsuarioCliente = new UsuarioCliente(nombre, apellido, email, contraseña, saldoDisponible);
            nuevoUsuarioCliente.Validar();
            if (!_usuarios.Contains(nuevoUsuarioCliente))
            {
                _usuarios.Add(nuevoUsuarioCliente);
            }
        }

        private void PrecargarArticulos()
        {
            AgregarArticulo("Laptop", "Electrónica", 1500.99);
            AgregarArticulo("Smartphone", "Electrónica", 899.99);
            AgregarArticulo("Cámara Digital", "Fotografía", 450.50);
            AgregarArticulo("Televisor 4K", "Electrónica", 1200.75);
            AgregarArticulo("Auriculares", "Accesorios", 75.30);
            AgregarArticulo("Reloj Inteligente", "Accesorios", 199.99);
            AgregarArticulo("Teclado Mecánico", "Periféricos", 150.00);
            AgregarArticulo("Mouse Gamer", "Periféricos", 50.25);
            AgregarArticulo("Impresora Láser", "Oficina", 300.00);
            AgregarArticulo("Tablet", "Electrónica", 350.75);
            AgregarArticulo("Bicicleta", "Deportes", 800.00);
            AgregarArticulo("Patineta Eléctrica", "Deportes", 550.00);
            AgregarArticulo("Silla Gamer", "Muebles", 250.50);
            AgregarArticulo("Escritorio", "Muebles", 150.75);
            AgregarArticulo("Lámpara de Escritorio", "Iluminación", 40.99);
            AgregarArticulo("Colchón", "Muebles", 300.25);
            AgregarArticulo("Sofá", "Muebles", 700.50);
            AgregarArticulo("Zapatillas Deportivas", "Ropa", 120.00);
            AgregarArticulo("Camiseta", "Ropa", 20.99);
            AgregarArticulo("Chaqueta", "Ropa", 75.50);
            AgregarArticulo("Pantalones", "Ropa", 45.25);
            AgregarArticulo("Bolso", "Accesorios", 60.00);
            AgregarArticulo("Gorra", "Accesorios", 15.50);
            AgregarArticulo("Cinturón", "Accesorios", 25.00);
            AgregarArticulo("Lentes de Sol", "Accesorios", 50.75);
            AgregarArticulo("Juego de Ollas", "Cocina", 120.00);
            AgregarArticulo("Cuchillos de Cocina", "Cocina", 70.99);
            AgregarArticulo("Licuadora", "Cocina", 80.50);
            AgregarArticulo("Tostadora", "Cocina", 30.75);
            AgregarArticulo("Microondas", "Electrodomésticos", 150.25);
            AgregarArticulo("Aspiradora", "Electrodomésticos", 200.00);
            AgregarArticulo("Ventilador", "Electrodomésticos", 60.50);
            AgregarArticulo("Lavadora", "Electrodomésticos", 500.99);
            AgregarArticulo("Secadora", "Electrodomésticos", 450.50);
            AgregarArticulo("Refrigerador", "Electrodomésticos", 900.75);
            AgregarArticulo("Cafetera", "Cocina", 100.25);
            AgregarArticulo("Tetera", "Cocina", 40.50);
            AgregarArticulo("Planchita de Pelo", "Belleza", 50.99);
            AgregarArticulo("Secador de Pelo", "Belleza", 70.75);
            AgregarArticulo("Espejo de Maquillaje", "Belleza", 30.99);
            AgregarArticulo("Perfume", "Belleza", 120.00);
            AgregarArticulo("Juego de Toallas", "Hogar", 40.25);
            AgregarArticulo("Sábanas", "Hogar", 60.75);
            AgregarArticulo("Cortinas", "Hogar", 45.50);
            AgregarArticulo("Alfombra", "Hogar", 80.99);
            AgregarArticulo("Reloj de Pared", "Decoración", 25.75);
            AgregarArticulo("Cuadro Decorativo", "Decoración", 60.50);
            AgregarArticulo("Florero", "Decoración", 20.99);
            AgregarArticulo("Planta Artificial", "Decoración", 15.75);
        }

        public void AgregarArticulo(string nombre, string categoria, double precioVenta)
        {
            Articulo nuevoArticulo = new Articulo(nombre, categoria, precioVenta);
            nuevoArticulo.Validar();
            if (!_articulos.Contains(nuevoArticulo))
            {
                _articulos.Add(nuevoArticulo);
            }
        }

        private void PrecargarPublicacionesVenta()
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

        public void AltaPublicacionVenta(PublicacionVenta publicacionVenta)
        {
            publicacionVenta.Validar();
            if (!_publicaciones.Contains(publicacionVenta))
            {
                _publicaciones.Add(publicacionVenta);
            }
        }

        private void PrecargarPublicacionesSubasta()
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

            AltaPublicacionSubasta(new PublicacionSubasta("Para el pelo", "ABIERTA", new DateTime(2024, 10, 05), BuscarArticulo(38)));
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

        public void AltaPublicacionSubasta(PublicacionSubasta publicacionSubasta)
        {
            publicacionSubasta.Validar();
            if (!_publicaciones.Contains(publicacionSubasta))
            {
                _publicaciones.Add(publicacionSubasta);
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
            if (publicacion != null && publicacion is PublicacionSubasta && usuario != null && usuario is UsuarioCliente)
            {
                UsuarioCliente usuarioCliente = (UsuarioCliente)usuario;
                PublicacionSubasta publicacionSubasta = (PublicacionSubasta)publicacion;
                publicacionSubasta.AltaOferta(usuarioCliente, monto, fecha);
                publicacionSubasta.CalcularPrecio();
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
            if (publicacion != null && articulo != null && !publicacion.ContieneArticulo(articulo))
            {
                publicacion.AgregarArticulo(articulo);
                publicacion.CalcularPrecio();
            }
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
                    UsuarioCliente usuarioCliente = (UsuarioCliente)usuario;
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

        /// <summary>
        /// Metodo que devuelve las Publicaciones entre dos fechas
        /// </summary>
        /// <param name="fecha1"></param>
        /// <param name="fecha2"></param>
        /// <returns></returns>

        public List<Publicacion> DevolverPublicacionesEntreDosFechas(DateTime fecha1, DateTime fecha2)
        {
            List<Publicacion> listaPublicaciones = new List<Publicacion>();
            DateTime primeraFecha;
            DateTime segundaFecha;
            if (fecha1 > fecha2)
            {
                primeraFecha = fecha2;
                segundaFecha = fecha1;
            }
            else
            {
                if (fecha1 < fecha2)
                {
                    primeraFecha = fecha1;
                    segundaFecha = fecha2;
                }
                else
                {
                    primeraFecha = fecha1;
                    segundaFecha = fecha1;
                }
            }

            foreach (Publicacion publicacion in _publicaciones)
            {
                if (publicacion.FechaPublicacion >= primeraFecha && publicacion.FechaPublicacion <= segundaFecha)
                {
                    listaPublicaciones.Add(publicacion);
                }
            }
            return listaPublicaciones;
        }
    }
}
