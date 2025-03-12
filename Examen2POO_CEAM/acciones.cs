using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2POO_CEAM
{
    internal class acciones
    {
        public List<Libros> listalibros = new List<Libros>();
        Libros l = new Libros();

        public void AgregarLibro()
        {
            

            Console.WriteLine("Nombre:");
            l.nombre = Console.ReadLine();
            Console.WriteLine("Editorial:");
            l.editorial = Console.ReadLine();
            Console.WriteLine("Autor:");
            l.autor = Console.ReadLine();
            Console.WriteLine("Paginas:");
            l.paginas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Genero:");
            l.genero = Console.ReadLine();

            listalibros.Add(new Libros (l.nombre,l.editorial,l.autor,l.paginas,l.genero));
        }
        public void MostrarLibros()
        {
            foreach(var libro in listalibros)
            {
                Console.WriteLine($"Nombre:{libro.nombre}");
                Console.WriteLine($"Editorial:{libro.editorial}");
                Console.WriteLine($"Autor:{libro.autor}");
                Console.WriteLine($"Paginas:{libro.paginas}");
                Console.WriteLine($"Genero:{libro.genero}");

            }
        }
        public int ContarLibros()
        {
            return listalibros.Count;
        }
        public void EliminarLibros(string nombrelibro)
        {
            var libro = listalibros.Find(x => x.nombre == nombrelibro);
            if (libro != null)
            {
                listalibros.Remove(libro);
            }
            else
            {
                Console.WriteLine("No se encontro el libro");
            }
        }
        public void Actualizar(string nombrelibro)
        {
            Console.WriteLine("Dame el libro a actualizar:");
            string nombreantiguo = Console.ReadLine();
           

            var libros = listalibros.Find(x => x.nombre == nombrelibro);
            if (libros != null)
            {
                Console.WriteLine("Introduce el nuevo nombre del libro:");
                libros.nombre = Console.ReadLine();
                Console.WriteLine("Introduce la nueva editorial:");
                libros.editorial = Console.ReadLine();
                Console.WriteLine("Introduce el nuevo autor:");
                libros.autor = Console.ReadLine();
                Console.WriteLine("Introduce las nuevas paginas:");
                libros.paginas = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el nuevo genero:");
                libros.genero = Console.ReadLine();
                Console.WriteLine("Codigo exitoso");
            }
            else
            {
                Console.WriteLine("No se encontró ningún libro con ese nombre");
            }
        }

    }
}
