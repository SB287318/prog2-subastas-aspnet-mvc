using LogicaNegocio;

namespace InterfazUsuario
{
    internal class Program
    {
        private static Sistema miSistema = new Sistema();

        static void Main(string[] args)
        {
            DesplegarMenu();
        }

        static void DesplegarMenu()
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

        static void EvaluarInput(int input)
        {
            switch (input)
            {
                case 1:
                    MostrarTodosLosClientes();
                    break;
                case 2:
                    MostrarArticulosSegunCategoria();
                    break;

            }
            Console.WriteLine("\n---------------------------\n");
        }

        static void MostrarTodosLosClientes()
        {
            List<UsuarioCliente> listaClientes = miSistema.DevolverTodosLosClientes();
            foreach (UsuarioCliente cliente in listaClientes)
            {
                Console.WriteLine(cliente.ToString());
            }
        }

        static void MostrarArticulosSegunCategoria()
        {
            Console.WriteLine("Ingrese el nombre de la categoría");
            List<Articulo> listaArticuloDeCategoria = miSistema.DevolverListaArticulosConCategoria(Console.ReadLine());
            foreach (Articulo articulo in listaArticuloDeCategoria)
            {
                Console.WriteLine(articulo.ToString());
            }
        }

    }
}
