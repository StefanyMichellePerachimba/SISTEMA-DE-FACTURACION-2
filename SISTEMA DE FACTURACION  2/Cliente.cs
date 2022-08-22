using System;


namespace SISTEMA_DE_FACTURACION__2
{
    internal class Cliente : BaseDatosGeneral
    {

        public string Ucompra;
        public string MetodoPago;
        public string ECivil;
    
        public Cliente(string _nombre, string _direccion, string _ID, string _genero, string _email, string _nTelefono, string _Ucompra,  Consola _consola, string _MetodoPago, string _ECivil) : base(_nombre, _direccion, _ID, _genero, _email, _nTelefono, _consola)
        {

            this.Ucompra = _Ucompra;
            this.MetodoPago = _MetodoPago;
            this.ECivil = _ECivil;
        }

        public void MostrarMembreteTabla()
        {

            consola.Escribir(5, 5, ConsoleColor.Blue, "ULTIMA COMPRA"); 
            consola.Escribir(25, 5, ConsoleColor.Blue, "METODO PAGO"); 
            consola.Escribir(65, 5, ConsoleColor.Blue, "ESTADO CIVIL");
            // consola.Marco(3, 4, 90, 15);
            consola.Marco(4, 6, 96, 21);
        }

        public void MostrarInfoComoFila(int Num, int fila)
        {
            base.mostrarInfoComoFila(Num, fila);
            consola.Escribir(10, fila, ConsoleColor.White, Ucompra);
            consola.Escribir(25, fila, ConsoleColor.White, MetodoPago);
            consola.Escribir(45, fila, ConsoleColor.White, ECivil);

        }

        public override void MostrarInfo()
        {
            consola.Escribir(30, 2, ConsoleColor.Red, "INFORMACIÓN DEL CLIENTE");
            consola.Marco(10, 3, 65, 11);
            base.MostrarInfo();
            consola.Marco(10, 3, 65, 11);
            consola.Escribir(20, 5, ConsoleColor.Yellow, "ULTIMA COMPRA ");
            consola.Escribir(35, 5, ConsoleColor.White, Ucompra);
            consola.Escribir(20, 5, ConsoleColor.Yellow, "METODO DE PAGO: ");
            consola.Escribir(35, 5, ConsoleColor.White, MetodoPago);
            consola.Escribir(20, 6, ConsoleColor.Yellow, "ESTADO CIVIL ");
            consola.Escribir(35, 6, ConsoleColor.White, ECivil);


        }

        public void leerInfoCliente(BaseDatosGeneral BD)
        {

            consola.Escribir(30, 2, ConsoleColor.Red, "NUEVO CLIENTE");
            consola.Marco(10, 3, 65, 11);
            consola.Escribir(20, 5, ConsoleColor.Yellow, "ULTIMA COMPRA: ");
            consola.Escribir(20, 6, ConsoleColor.Yellow, "METODO DE PAGO: ");
            consola.Escribir(20, 7, ConsoleColor.Yellow, "ESTADO CIVIL: ");

            Ucompra = consola.leerCadena(35, 5);
            MetodoPago = consola.leerCadena(35, 6);
            ECivil = consola.leerCadena(35, 7);
         

        }

    }

}
