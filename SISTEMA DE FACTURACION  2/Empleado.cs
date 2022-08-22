using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_DE_FACTURACION__2
{
    internal class Empleado : BaseDatosGeneral
    {
        public double sueldo;
        public string AñosExperiencia;
        public string cargo;
        public string Obsercaciones;
        public string departamento;
        public string FechaContratacion;



        public Empleado(string _nombre, string _direccion, string _ID, string _genero, string _email, string _nTelefono, Consola _consola,
            string _sueldo, string _AñosExperiencia, string _cargo, string _Observaciones, string _departamento, string _FechaContratacion) : base(_nombre, _direccion, _ID, _genero, _email, _nTelefono, _consola)
        {
            sueldo = 0;
            this.cargo = _cargo;
            this.AñosExperiencia = _AñosExperiencia;
            this.Obsercaciones = _Observaciones;
            this.departamento = _departamento;
            this.FechaContratacion = _FechaContratacion;

        }

        public  void MostrarMembreteTabla()
        {
            base.mostrarMembreteTabla();
            consola.Escribir(5, 5, ConsoleColor.Blue, "SUELDO");
            consola.Escribir(10, 5, ConsoleColor.Blue, "AÑOS DE EXPERIENCIA");
            consola.Escribir(25, 5, ConsoleColor.Blue, "CARGO");
            consola.Escribir(50, 5, ConsoleColor.Blue, "OBSERVACIONES");
            consola.Escribir(65, 5, ConsoleColor.Blue, "DEPARTAMENTO");
            consola.Escribir(80, 5, ConsoleColor.Blue, "FECHA DE CONTRATACION");
            consola.Marco(3, 4, 90, 15);
        }

        public override void mostrarInfoComoFila(int Num, int fila)
        {
            base.mostrarInfoComoFila(Num, fila);


            sueldo.ToString("0.00");

            consola.Escribir(65, fila, ConsoleColor.White, AñosExperiencia);
            consola.Escribir(25, fila, ConsoleColor.White, cargo);
            consola.Escribir(80, fila, ConsoleColor.White, Obsercaciones);
            consola.Escribir(50, fila, ConsoleColor.White, departamento);
            consola.Escribir(80, fila, ConsoleColor.White, FechaContratacion);



        }
        public override void LeerInfo(BaseDatosGeneral BD)
        {
            consola.Marco(10, 3, 65, 11);
            consola.Escribir(30, 2, ConsoleColor.Red, "NUEVO EMPLEADO");
            base.LeerInfo(BD);
            consola.Escribir(20, 5, ConsoleColor.Yellow, "Sueldo: ");
            consola.Escribir(20, 6, ConsoleColor.Yellow, "Cargo: ");
            consola.Escribir(20, 7, ConsoleColor.Yellow, "Departamento: ");
            consola.Escribir(20, 8, ConsoleColor.Yellow, "Años de experiencia: ");
            consola.Escribir(20, 9, ConsoleColor.Yellow, "Horario de trabajo: ");

            sueldo = consola.leerNumeroDecimal(35, 13);
            cargo = consola.leerCadena(35, 7);
            departamento = consola.leerCadena(35, 7);
            AñosExperiencia = consola.leerCadena(35, 7);
            FechaContratacion = consola.leerCadena(35, 7);
            Obsercaciones = consola.leerCadena(35, 7);


        }

    }
}
