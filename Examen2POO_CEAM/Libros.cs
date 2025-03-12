using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2POO_CEAM
{
    internal class Libros
    {
        public Libros() { }

        public Libros(string nombre, string editorial, string autor, int paginas, string genero)
        {
            this.nombre = nombre;
            this.editorial = editorial;
            this.autor = autor;
            this.paginas = paginas;
            this.genero = genero;
        }



        //atributos
        public string nombre { get; set; }
        public string editorial {  get; set; }
        public string autor { get; set; }
        public int paginas { get; set; }
        public string genero { get; set; }

    }
}
