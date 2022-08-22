using System;


namespace SISTEMA_DE_FACTURACION__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Consola consola = new Consola(ConsoleColor.White);
            int opcion = 0;
            do
            {
                Console.Clear();
                consola.PintarFondo(ConsoleColor.Black);
                consola.MenuOpciones();
                opcion = consola.leerOpcion();
                switch (opcion)
                {
                    case 1:
                        MenuProducto();
                        break;
                    case 2:
                        MenuCliente();
                        break;
                    case 3:
                        MenuProveedores();
                        break;
                    case 4:
                        MenuEmpleados();

                        break;
                    case 5:

                        break;

                    default:
                        Console.Clear();
                        consola.Escribir(50, 1, ConsoleColor.Yellow, "FIN DEL PROGRAMA");
                        GC.Collect();
                        Console.Read();
                        break;

                }
            }
            while (opcion != 6);

        }
        static void MenuProducto()
        {
            Consola consola = new Consola(ConsoleColor.White);
            BaseDatosProducto bdProductos = new BaseDatosProducto(consola);

            int opcion = 0;
            do
            {
                Console.Clear();
                consola.PintarFondo(ConsoleColor.Black);
                consola.MenuOpcionesProducto();
                opcion = consola.leerOpcion();
                switch (opcion)
                {
                    case 1:
                        bdProductos.Crear();
                        break;
                    case 2:
                        bdProductos.Mostrar();
                        break;
                    case 3:
                        bdProductos.ActualizarPrecioProducto();
                        break;
                    case 4:
                        bdProductos.mostrarTabla();
                        break;
                    case 5:
                        bdProductos.Buscar();
                        break;
                    case 6:
                        bdProductos.Eliminar();
                        break;

                    default:
                        Console.Clear();
                        bdProductos = null;
                        GC.Collect();
                        break;

                }
            }
            while (opcion != 7);

        }
        static void MenuCliente()
        {
            Consola consola = new Consola(ConsoleColor.White);
            BaseDatosClientes bdCliente = new BaseDatosClientes(consola);

            int opcion = 0;
            do
            {
                Console.Clear();
                consola.PintarFondo(ConsoleColor.Black);
                consola.MenuOpcionesClientes();
                opcion = consola.leerOpcion();
                switch (opcion)
                {
                    case 1:
                        bdCliente.Crear();
                        break;
                    case 2:
                        bdCliente.Mostrar();
                        break;
                    case 3:

                        bdCliente.Buscar();

                        break;
                    case 4:
                        bdCliente.Eliminar();
                        break;
                    case 5:
                        bdCliente.mostrarTabla();
                        break;
                    //case 6:
                    //    bdCliente.ActualizarTelefonoCliente();
                    //    break;


                    default:
                        Console.Clear();
                        bdCliente = null;
                        GC.Collect();
                        break;

                }
            }
            while (opcion != 7);

        }

        static void MenuProveedores()
        {
            Consola consola = new Consola(ConsoleColor.White);
            BaseDatosProveedores bdProveedores = new BaseDatosProveedores(consola);

            int opcion = 0;
            do
            {
                Console.Clear();
                consola.PintarFondo(ConsoleColor.Black);
                consola.MenuOpcionesProveedor();
                opcion = consola.leerOpcion();
                switch (opcion)
                {
                    case 1:
                        bdProveedores.Crear();
                        break;
                    case 2:
                        bdProveedores.Mostrar();
                        break;
                    case 3:
                        bdProveedores.mostrarTabla();
                        break;
                    case 4:
                        bdProveedores.Buscar();
                        break;
                    case 5:
                        bdProveedores.Eliminar();
                        break;

                    default:
                        Console.Clear();
                        bdProveedores = null;
                        GC.Collect();
                        break;

                }
            }
            while (opcion != 5);

        }

        static void MenuEmpleados()
        {
            Consola consola = new Consola(ConsoleColor.White);
            BaseDatosEmpleados dbEmpleados  = new BaseDatosEmpleados(consola);

            int opcion = 0;
            do
            {
                Console.Clear();
                consola.PintarFondo(ConsoleColor.Black);
                consola.MenuOpcionesEmpleado();
                opcion = consola.leerOpcion();
                switch (opcion)
                {
                    case 1:
                        dbEmpleados.Crear();
                        break;
                    case 2:
                        dbEmpleados.Mostrar();
                        break;
                    case 3:
                        dbEmpleados.mostrarTabla();
                        break;
                    case 4:
                        dbEmpleados.Buscar();
                        break;
                    case 5:
                        dbEmpleados.Eliminar();
                        break;

                    default:
                        Console.Clear();
                        dbEmpleados = null;
                        GC.Collect();
                        break;

                }
            }
            while (opcion != 5);

        }

    }
}   
