using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestionEstudiantes
{
    public class Listas
    {
        private string nombre;
        private string carrera;
        private int matricula;

        public Listas()
        {
        }

        public Listas(string nombre, string carrera, int matricula)
        {
            this.nombre = nombre;
            this.carrera = carrera;
            this.matricula = matricula;
        }

        public void set_nombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void set_carrera(string carrera)
        {
            this.carrera = carrera;
        }

        public void set_matricula(int matricula)
        {
            this.matricula = matricula;
        }

        public string get_nombre()
        {
            return nombre;
        }

        public string get_carrera()
        {
            return carrera;
        }

        public int get_matricula()
        {
            return matricula;
        }

        public void imprimirTodo()
        {
            Console.WriteLine($"|Nombre: {nombre} |Carrera: {carrera} |Matricula: {matricula}");
        }

        public void Menu(List<Listas> OpcionLista)
        {
            string opcion;
            Console.WriteLine("MENU");
            Console.WriteLine("1-PARA VER TODOS LOS REGISTROS ALMACENADOS");
            Console.WriteLine("2-PARA BUSCAR REGISTROS ESPECÍFICOS");
            Console.WriteLine("3-PARA EDITAR");
            Console.WriteLine("4-PARA AGREGAR");
            Console.WriteLine("CUALQUIER LETRA DIFERENTE A LAS ANTERIORES PARA SALIR DEL PROGRAMA");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Almacen(OpcionLista);
                    break;
                case "2":
                    Buscar(OpcionLista);
                    break;
                case "3":
                    Editar(OpcionLista);
                    break;
                case "4":
                    Agregar(OpcionLista);
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }
        }

        public void Agregar(List<Listas> ListaAgregar)
        {
            string nombre_entrada;
            string carrera_entrada;
            int matricula_entrada;
            Console.WriteLine("INTRODUZCA EL NOMBRE: ");
            nombre_entrada = Console.ReadLine();
            Console.WriteLine("INTRODUZCA LA CARRERA: ");
            carrera_entrada = Console.ReadLine();
            Console.WriteLine("INTRODUZCA LA MATRICULA: ");
            matricula_entrada = int.Parse(Console.ReadLine());
            ListaAgregar.Add(new Listas(nombre_entrada, carrera_entrada, matricula_entrada));
            Console.WriteLine("OPERACION REALIZADA CON EXITO");
            Console.WriteLine("");
            Console.ReadKey();
            Menu(ListaAgregar);
        }

        public void Buscar(List<Listas> ListaBuscar)
        {
            int busqueda;
            Console.WriteLine("INGRESE LA MATRICULA QUE DESEA ENCONTRAR");
            busqueda = int.Parse(Console.ReadLine());
            int contador = 0;
            int contador2 = 0;
            for (int i = 0; i < ListaBuscar.Count; i++)
            {
                if (busqueda == ListaBuscar[i].get_matricula())
                {
                    contador2 = i;
                    contador++;
                    break;
                }
            }

            if (contador == 1)
            {
                ListaBuscar[contador2].imprimirTodo();
            }
            else
            {
                Console.WriteLine("NO SE ENCONTRARON RESULTADOS");
            }
            Console.WriteLine();
            Console.ReadKey();
            Menu(ListaBuscar);

        }

        public void Editar(List<Listas> ListaEditar)
        {
            int busqueda_editar;
            int contador = 0;
            int contador2 = 0;
            Console.WriteLine("INGRESE LA MATRICULA QUE DESEA EDITAR");
            busqueda_editar = int.Parse(Console.ReadLine());

            for (int i = 0; i < ListaEditar.Count; i++)
            {
                if (ListaEditar[i].get_matricula() == busqueda_editar)
                {
                    contador2 = i;
                    contador++;
                }
            }

            if (contador == 1)
            {
                Console.WriteLine("INTRODUZCA EL NUEVO NOMBRE: ");
                ListaEditar[contador2].set_nombre(Console.ReadLine());
                Console.WriteLine("INTRODUZCA LA CARRERA");
                ListaEditar[contador2].set_carrera(Console.ReadLine());
                Console.WriteLine("INTRODUZCA LA NUEVA MATRICULA: ");
                ListaEditar[contador2].set_matricula(int.Parse(Console.ReadLine()));

                Console.WriteLine("NUEVO REGISTRO: ");
                ListaEditar[contador2].imprimirTodo();

            }
            else
            {
                Console.WriteLine("NO SE ENCONTRARON REGISTROS DE LA MATRICULA QUE DESEA EDITAR");
            }
            Console.WriteLine("");
            Console.ReadKey();
            Menu(ListaEditar);

        }

        public void Almacen(List<Listas> ListaAlmacen)
        {
            Console.WriteLine("LISTA DE LOS DATOS ALMACENADOS: ");
            Console.WriteLine("");
            for (int i = 0; i < ListaAlmacen.Count; i++)
            {
                ListaAlmacen[i].imprimirTodo();
            }
            Console.WriteLine("");
            Console.ReadKey();
            Menu(ListaAlmacen);
        }
    }
}
