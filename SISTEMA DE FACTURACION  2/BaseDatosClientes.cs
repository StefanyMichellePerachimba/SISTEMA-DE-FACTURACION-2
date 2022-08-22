using System;
using System.Collections.Generic;


namespace SISTEMA_DE_FACTURACION__2
{
    internal  class BaseDatosClientes : BaseDatosGeneral
    {
        List<Cliente> bdCliente;


        public BaseDatosClientes(string _nombre, string _direccion, string _ID, string _genero, string _email, string _nTelefono, Consola _consola) : base(_nombre, _direccion,_ID, _genero, _email, _nTelefono, _consola)
        {

            bdCliente = new List<Cliente>();
   
        }

        public BaseDatosClientes(Consola consola) : base(consola)
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
            consola.Escribir(50, 1, ConsoleColor.Yellow, "BÚSQUEDA DE CLIENTES");
            consola.Escribir(10, 3, ConsoleColor.Blue, "Ingrese el ID del cliente a buscar: ");
        }

        public override void Eliminar()
        {
            base.Eliminar();
            consola.Escribir(50, 1, ConsoleColor.Yellow, "ELIMINAR CLIENTE");
            consola.Escribir(10, 3, ConsoleColor.Blue, "Ingrese el ID del cliente a eliminar: ");
        }

        public override void mostrarTabla()
        {
            base.mostrarTabla();
            consola.Escribir(40, 1, ConsoleColor.Yellow, "LISTA DE CLIENTES");
        }

       
    }
}
