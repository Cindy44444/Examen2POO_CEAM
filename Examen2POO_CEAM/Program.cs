using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2POO_CEAM
{
    internal class Program
    {
        public enum Menu
        {
            Agregar=1,Mostrar,Contar, Eliminar,Actualizar
        }
        static void Main(string[] args)
        {
            acciones Acciones = new acciones();
            while (true)
            {
                switch (menu())
                {
                    case Menu.Agregar:
                        Acciones.AgregarLibro();
                        break;
                    case Menu.Mostrar:
                        Acciones.MostrarLibros();
                        break;
                    case Menu.Contar:
                        Console.WriteLine(Acciones.ContarLibros());
                        break;
                    case Menu.Eliminar:
                        Console.WriteLine("Dame el libro a eliminar:");
                        string nombre = Console.ReadLine();
                        Acciones.EliminarLibros(nombre);
                        break;
                    case Menu.Actualizar:
                        Console.WriteLine("Dame el libro a eliminar:");
                        string nombre2 = Console.ReadLine();
                        Acciones.Actualizar(nombre2);
                        break;
                }
            }
        }

        static Menu menu()
        {
            Console.WriteLine("1)Agregar libro:");
            Console.WriteLine("2)Mostrar libro:");
            Console.WriteLine("3)Contar total de libros:");
            Console.WriteLine("4) Eliminar libros:");
            Console.WriteLine("5)Actualizar");
            Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());
            return opc;
        }

    }
}
