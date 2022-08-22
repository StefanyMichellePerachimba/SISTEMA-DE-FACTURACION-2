using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_DE_FACTURACION__2
{
    internal class BaseDatosProveedores : BaseDatosGeneral
    {
        List<BaseDatosProveedores> bdProveedores;
        public BaseDatosProveedores(string _nombre, string _direccion, string _ID, string _genero, string _email, string _nTelefono, Consola _consola)
            : base(_nombre, _direccion, _ID, _genero, _email, _nTelefono, _consola)
        {
            bdProveedores = new List<BaseDatosProveedores>();
        }

        public BaseDatosProveedores(Consola consola) : base(consola)
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
            consola.Escribir(50, 1, ConsoleColor.Yellow, "BUSCAR EL PROVEEDOR");
            consola.Escribir(10, 3, ConsoleColor.Blue, "INGRESE EL ID:  ");
        }

        public override void Eliminar()
        {
            base.Eliminar();
            consola.Escribir(50, 1, ConsoleColor.Yellow, "ELIMINAR PROVEEDOR");
            consola.Escribir(10, 3, ConsoleColor.Blue, "INGRESE EL ID PARA ELIMINAR: ");
        }

        public override void mostrarTabla()
        {
            base.mostrarTabla();
            consola.Escribir(40, 1, ConsoleColor.Yellow, " PROVEEDORES");
        }


    }
}
