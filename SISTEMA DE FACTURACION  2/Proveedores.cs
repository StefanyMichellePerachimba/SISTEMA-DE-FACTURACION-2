using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_DE_FACTURACION__2
{
    internal class Proveedores : BaseDatosGeneral
    {
        public string empresa;
        public string codigo;
        public string TipoProduc;
        public double  cantidad;

        public Proveedores(string _nombre, string _direccion, string _ID, string _genero, string _email, string _nTelefono, Consola _consola,
            string _empresa, string _codigo, string _TipoProduc, double cantidad) : base(_nombre, _direccion, _ID, _genero, _email, _nTelefono, _consola)
        {
            this.empresa = _empresa;
            this.codigo = _codigo;
            this.TipoProduc = _TipoProduc;
            cantidad = 0;           
        }
        public  void MostrarMembreteTabla()
        {
            base.mostrarMembreteTabla();
            consola.Escribir(5, 5, ConsoleColor.Blue, "EMPRESA");
            consola.Escribir(10, 5, ConsoleColor.Blue, "CODIGO");
            consola.Escribir(25, 5, ConsoleColor.Blue, "TIPO DE PRODUCTO");
            consola.Escribir(50, 5, ConsoleColor.Blue, "CANTIDAD DE PRODUCTO");
            consola.Marco(3, 4, 90, 15);
        }

        public override void mostrarInfoComoFila(int Num, int fila)
        {
            base.mostrarInfoComoFila(Num, fila);



            consola.Escribir(25, fila, ConsoleColor.White, empresa);
            consola.Escribir(50, fila, ConsoleColor.White, codigo);
            consola.Escribir(65, fila, ConsoleColor.White, TipoProduc);
            cantidad.ToString();



        }
        public override void LeerInfo(BaseDatosGeneral BD)
        {
            consola.Marco(10, 3, 65, 11);
            consola.Escribir(30, 2, ConsoleColor.Red, "NUEVO PROVEEDOR");
            base.LeerInfo(BD);
            consola.Escribir(20, 5, ConsoleColor.Yellow, "EMPRESA: ");
            consola.Escribir(20, 6, ConsoleColor.Yellow, "CODIGO: ");
            consola.Escribir(20, 7, ConsoleColor.Yellow, "TIPO DE PRODUCTO ");
            consola.Escribir(20, 8, ConsoleColor.Yellow, "CANTIDAD DE PRODUCTO ");



            empresa = consola.leerCadena(35, 7);
            codigo = consola.leerCadena(35, 7);
            TipoProduc = consola.leerCadena(35, 7);
            cantidad = consola.leerNumeroEntero(35, 7);



        }


    }
}
