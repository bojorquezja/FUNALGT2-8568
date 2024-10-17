using Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nousar.Personas
{
    internal class Salon
    {

        public Entrenador Entr1 { get; set; }
        public Estudiante Estu1 { get; set; }
        public Estudiante Estu2 { get; set; }
        public Estudiante Estu3 { get; set; }

        public void Pasarlista()
        {
            Console.WriteLine($"Entrenador: {Entr1.Nombre}");
            Console.WriteLine($"Estudiante 1: {Estu1.Nombre}");
            Console.WriteLine($"Estudiante 2: {Estu2.Nombre}");
            Console.WriteLine($"Estudiante 3: {Estu3.Nombre}");
        }

    }
}
