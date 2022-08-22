using System;
using System.Collections.Generic;


namespace SISTEMA_DE_FACTURACION__2
{
    internal class BaseDatosProducto : BaseDatosGeneral
    {
        List<Producto> bdProductos;
        public BaseDatosProducto(string _nombre, string _direccion, string _ID, string _genero, string _email, string _nTelefono, Consola _consola) 
            : base(_nombre, _direccion, _ID, _genero, _email, _nTelefono, _consola)
        {
            bdProductos = new List<Producto>();

        }

        public BaseDatosProducto(Consola consola) : base(consola)
        {
        }

        public override void Crear()
        {
            base.Crear();
        }

        public override void Mostrar()
        {
            base.Mostrar();
        }

        public override bool Vacia()
        {
            return base.Vacia();
        }

        public override void Buscar()
        {
            base.Buscar();
            consola.Escribir(50, 1, ConsoleColor.Yellow, "BÚSQUEDA DE PRODUCTOS");
            consola.Escribir(10, 3, ConsoleColor.Blue, "Ingrese el código del producto a buscar: ");
        }

        public override void Eliminar()
        {
            base.Eliminar();
            consola.Escribir(50, 1, ConsoleColor.Yellow, "ELIMINAR PRODUCTO");
            consola.Escribir(10, 3, ConsoleColor.Blue, "Ingrese el código del producto a eliminar: ");
        }

        public override void mostrarTabla()
        {
            base.mostrarTabla();
            consola.Escribir(40, 1, ConsoleColor.Yellow, "LISTA DE PRODUCTOS");
        }



    }
}
