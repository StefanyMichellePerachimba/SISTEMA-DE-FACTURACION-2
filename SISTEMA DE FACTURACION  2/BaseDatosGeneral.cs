using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISTEMA_DE_FACTURACION__2
{
    internal class BaseDatosGeneral
    {

        public string nombre;
        public string direccion;
        public string ID;
        public string genero;
        public string email;
        public string nTelefono;
        protected Consola consola;
        List<BaseDatosGeneral> BdGeneral;

        public BaseDatosGeneral(string _nombre, string _direccion, string _ID, string _genero, string _email, string _nTelefono, Consola consola)
        {
            this.nombre = _nombre;
            this.direccion = _direccion;
            this.ID = _ID;
            this.genero = _genero;
            this.email = _email;
            this.nTelefono = _nTelefono;
            this.consola = consola;
            BdGeneral = new List<BaseDatosGeneral>();

        }
        public BaseDatosGeneral(Consola consola)
        {
            this.consola = consola;
        }

        public virtual void mostrarMembreteTabla()
        {
            consola.Escribir(5, 5, ConsoleColor.Blue, "NOMBRE");
            consola.Escribir(80, 5, ConsoleColor.Blue, "DIRECCION");
            consola.Escribir(25, 5, ConsoleColor.Blue, "ID");
            consola.Escribir(50, 5, ConsoleColor.Blue, "GENERO");
            consola.Escribir(65, 5, ConsoleColor.Blue, "EMAIL");
            consola.Escribir(95, 5, ConsoleColor.Blue, "N° TELEFONO");
            consola.Marco(3, 4, 90, 15);
        }
        public virtual void mostrarInfoComoFila(int Num, int fila)
        {

            consola.Escribir(10, fila, ConsoleColor.White, nombre);
            consola.Escribir(95, fila, ConsoleColor.White, direccion);
            consola.Escribir(50, fila, ConsoleColor.White, ID);
            consola.Escribir(65, fila, ConsoleColor.White, genero);
            consola.Escribir(80, fila, ConsoleColor.White, email);
            consola.Escribir(115, fila, ConsoleColor.White, nTelefono);


        }
        public virtual void MostrarInfo()
        {

            consola.Marco(10, 3, 65, 11);
            consola.Escribir(20, 5, ConsoleColor.Yellow, "NOMBRE: ");
            consola.Escribir(35, 5, ConsoleColor.White, nombre);
            consola.Escribir(20, 10, ConsoleColor.Yellow, "DIRECCION: ");
            consola.Escribir(35, 10, ConsoleColor.White, direccion);
            consola.Escribir(20, 7, ConsoleColor.Yellow, "ID: ");
            consola.Escribir(35, 7, ConsoleColor.White, ID);
            consola.Escribir(20, 8, ConsoleColor.Yellow, "GENERO: ");
            consola.Escribir(35, 8, ConsoleColor.White, genero);
            consola.Escribir(20, 9, ConsoleColor.Yellow, "EMAIL: ");
            consola.Escribir(35, 9, ConsoleColor.White, email);
            consola.Escribir(20, 11, ConsoleColor.Yellow, "N° TELEFONO: ");
            consola.Escribir(35, 11, ConsoleColor.White, nTelefono);

        }
        public virtual void LeerInfo(BaseDatosGeneral BD)
        {

            consola.Marco(12, 4, 65, 11);
            consola.Escribir(20, 5, ConsoleColor.Yellow, "NOMBRE");
            consola.Escribir(20, 6, ConsoleColor.Yellow, "ID");
            consola.Escribir(20, 7, ConsoleColor.Yellow, "DIRECCION");
            consola.Escribir(20, 8, ConsoleColor.Yellow, "GENERO");
            consola.Escribir(20, 9, ConsoleColor.Yellow, "EMAIL");
            consola.Escribir(20, 10, ConsoleColor.Yellow, "N° TELEFONO");
            do
            {
                ID = consola.leerCadena(35, 5);
                if (BD.Buscar(ID) == null) //Si es Igual a NULL significa NO encontrado
                {
                    break;
                }
                else
                {
                    consola.Escribir(20, 13, ConsoleColor.Red, "NUMERO DE ID: " + ID + " YA REGISTRADO");
                    Console.ReadLine();
                    consola.Escribir(20, 13, ConsoleColor.Red, "  ");


                }

            } while (true);

            // un mov

            nombre = consola.leerCadena(35, 6);
            direccion = consola.leerCadena(35, 7);
            ID = consola.leerCadena(35, 8);
            genero = consola.leerCadena(35, 9);
            email = consola.leerCadena(35, 10);
            nTelefono = consola.leerCadena(35, 11);
        }
        public virtual void Crear()
        {
            Console.Clear();
            consola.PintarFondo(ConsoleColor.Black);
            BaseDatosGeneral nuevabase = new BaseDatosGeneral(consola);
            nuevabase.LeerInfo(this);
            BaseDatosGeneral encontrado = Buscar(nuevabase.ID);
            if (encontrado == null) //NO HAY PRODUCTO CON EL MISMO CODIGO
            {
                BdGeneral.Add(nuevabase);
                consola.Escribir(25, 13, ConsoleColor.Blue, "AGREGADO!!");
            }
            else
            {
                consola.Escribir(25, 13, ConsoleColor.Red, " DUPLICADO!!");
            }
            Console.ReadLine();
        }
        public virtual void Mostrar()
        {
            Console.Clear();
            consola.PintarFondo(ConsoleColor.Black);
            foreach (BaseDatosGeneral itembase in BdGeneral)
            {
                itembase.MostrarInfo();
                Console.ReadLine();
            }
        }
        public BaseDatosGeneral Buscar(String id) /// ob
        {
            foreach (BaseDatosGeneral itembase in BdGeneral)
            {
                if (itembase.ID == id)
                {
                    return itembase;
                }
            }
            return null; //Not found by code
        }
        public virtual void Eliminar()
        {
            Console.Clear();
            consola.PintarFondo(ConsoleColor.Black);

            string OBJ = consola.leerCadena(70, 3);
            BaseDatosGeneral encontrado = Buscar(OBJ);
            if (encontrado == null)
            {
                consola.Escribir(25, 13, ConsoleColor.Red, " NO ENCONTRADO!!");
            }
            else
            {
                Console.Clear();
                consola.PintarFondo(ConsoleColor.Black);
                encontrado.MostrarInfo();
                BdGeneral.Remove(encontrado);
                consola.Escribir(25, 13, ConsoleColor.Red, "ELIMINADO!!");
            }
            Console.ReadLine();
        }
        public virtual void Buscar()
        {
            Console.Clear();
            consola.PintarFondo(ConsoleColor.Black);

            string OBJ = consola.leerCadena(70, 3);
            BaseDatosGeneral encontrado = Buscar(OBJ);
            if (encontrado == null)
            {
                consola.Escribir(25, 13, ConsoleColor.Red, " No encontrado!!");
            }
            else
            {
                Console.Clear();
                consola.PintarFondo(ConsoleColor.Black);
                encontrado.MostrarInfo();
            }
            Console.ReadLine();
        }
        public void ActualizarPrecioProducto()
        {
            Console.Clear();
            consola.PintarFondo(ConsoleColor.Black);
            consola.Escribir(50, 1, ConsoleColor.Yellow, "ACTUALIZAR PRECIO PRODUCTO");
            consola.Escribir(10, 3, ConsoleColor.Blue, "Ingrese el código del producto a actualizar: ");
            string OBJ = consola.leerCadena(70, 3);
            BaseDatosGeneral encontrado = Buscar(OBJ);
            if (encontrado == null)
            {
                consola.Escribir(25, 13, ConsoleColor.Red, "Producto no encontrado!!");
            }
            else
            {

                encontrado.ActualizarPrecio(); Console.ReadLine();
            }
        }

        private void ActualizarPrecio()
        {
            throw new NotImplementedException();
        }

        public virtual Boolean Vacia()
        {
            if (BdGeneral.Count > 0)
                return false;
            else
                return true;
        }
        public virtual void mostrarTabla()
        {
            Console.Clear();
            consola.PintarFondo(ConsoleColor.Black);
            if (Vacia())
            {
                consola.Escribir(40, 3, ConsoleColor.Red, "BASE DE DATOS VACÍA");
            }
            else
            {
                BaseDatosGeneral BD = new BaseDatosGeneral(consola);
                BD.mostrarMembreteTabla();
                int num = 1; int fila = 7;
                foreach (BaseDatosGeneral itembase in BdGeneral)
                {
                    
                    if (num % 7 == 0)
                    {
                        Console.ReadLine();
                        Console.Clear();
                        consola.PintarFondo(ConsoleColor.Black); consola.Escribir(40, 1, ConsoleColor.Yellow, "FACTURACIÓN");
                        BD.mostrarMembreteTabla();
                        fila = 7;
                    }
                    itembase.mostrarInfoComoFila(num++,fila++);
                }
            }
            Console.ReadLine();
        }

    }
}
