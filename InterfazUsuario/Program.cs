using LogicaNegocio;

namespace InterfazUsuario
{
    internal class Program
    {
        private static Sistema miSistema = new Sistema();

        static void Main(string[] args)
        {
            try
            {
                DesplegarMenu();
            }
            catch { }
        }

        static void DesplegarMenu()
        {
            try
            {
                int input = 1;
                while (input != 0)
                {
                    Console.WriteLine("Ingrese el nro de la funcion deseada:\n[1] - Listado de todos los clientes.\n[2] - Dado un nombre de categoría listar todos los artículos de esa categoría.\n[3] - Alta de artículo.\n[4] - Dadas dos fechas, listar las publicaciones entre esas fechas.\n[0] - Finalizar programa.");
                    int.TryParse(Console.ReadLine(), out input);
                    Console.Clear();
                    EvaluarInput(input);
                }
            }
            catch { }
        }

        /// <summary>
        /// Evalua el input del usuario
        /// </summary>
        /// <param name="input"></param>

        static void EvaluarInput(int input)
        {
            try
            {
                switch (input)
                {
                    case 1:
                        MostrarTodosLosClientes();
                        break;
                    case 2:
                        MostrarArticulosSegunCategoria();
                        break;
                    case 3:
                        AltaArticulo();
                        break;
                    case 4:
                        MostrarPublicacionesEntreDosFechas();
                        break;

                }
                Console.WriteLine("\n---------------------------\n");
            }
            catch { }
        }

        /// <summary>
        /// Metodo que muestra todos los clientes
        /// </summary>
        static void MostrarTodosLosClientes()
        {
            try
            {

                List<UsuarioCliente> listaClientes = miSistema.DevolverTodosLosClientes();
                if (listaClientes.Count == 0)
                {
                    Console.WriteLine("No hay ningun cliente registrado");
                }
                else
                {
                    foreach (UsuarioCliente cliente in listaClientes)
                    {
                        Console.WriteLine(cliente);
                    }
                }
            }
            catch { }
        }

        /// <summary>
        /// Metodo que muestra todos los articulos de una categoria
        /// </summary>
        static void MostrarArticulosSegunCategoria()
        {
            try
            {
                Console.WriteLine("Ingrese el nombre de la categoría");
                List<Articulo> listaArticuloDeCategoria = miSistema.DevolverListaArticulosConCategoria(Console.ReadLine());
                if (listaArticuloDeCategoria.Count == 0)
                {
                    Console.WriteLine("No hay ningun articulo con esa categoría");
                }
                else
                {
                    foreach (Articulo articulo in listaArticuloDeCategoria)
                    {
                        Console.WriteLine(articulo);
                    }
                }
            }
            catch { }
        }

        public static void AltaArticulo()
        {
            try
            {
                Console.WriteLine("Ingrese un nombre");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese una categoria");
                string categoria = Console.ReadLine();
                Console.WriteLine("Ingrese precio de venta");
                double.TryParse(Console.ReadLine(), out double precioVenta);

                if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(categoria) && precioVenta > 0)
                {
                    miSistema.AgregarArticulo(nombre, categoria, precioVenta);
                    Console.WriteLine("El articulo fue creado exitosamente");
                }
            }
            catch { }
        }

        public static void MostrarPublicacionesEntreDosFechas()
        {
            try
            {

                Console.WriteLine("Ingrese primera fecha: yy/mm/dd");
                DateTime.TryParse(Console.ReadLine(), out DateTime fecha1);
                Console.WriteLine("Ingrese segunda fecha: yy/mm/dd");
                DateTime.TryParse(Console.ReadLine(), out DateTime fecha2);
                List<Publicacion> publicacionesDevueltas = miSistema.DevolverPublicacionesEntreDosFechas(fecha1, fecha2);
                if (publicacionesDevueltas.Count == 0)
                {
                    Console.WriteLine("No hay publicaciones entre esas fechas");
                }
                else
                {
                    foreach (Publicacion publicacion in publicacionesDevueltas)
                    {
                        Console.WriteLine(publicacion);
                    }
                }
            }
            catch { }
        }
    }
}

