using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad;
            string nombre;
            string carrera;
            int matricula;
            Console.WriteLine("INGRESE LA CANTIDAD DE ALUMNOS QUE QUIERE AGREGAR INICIALMENTE");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            List<Listas> ObjLista = new List<Listas>();
            Listas Menu = new Listas();
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("INTRODUZCA EL NOMBRE");
                nombre = Console.ReadLine();

                Console.WriteLine("INTRODUZCA LA CARRERA");
                carrera = Console.ReadLine();

                Console.WriteLine("INTRODUZCA LA MATRICULA");
                matricula = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                ObjLista.Add(new Listas(nombre, carrera, matricula));
            }
            Console.ReadKey();
            Menu.Menu(ObjLista);
        }
    }
}
