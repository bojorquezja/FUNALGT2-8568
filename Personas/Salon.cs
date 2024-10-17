using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    internal class Salon
    {
        public Entrenador Ent1 { get; set; }
        public Estudiante Est1 { get; set; }
        public Estudiante Est2 { get; set; }

        public Estudiante Est3 { get; set; }


        public void pasarAsistencia()
        {
            Console.WriteLine($"Entrenador: {Ent1.Nombre}");
            Console.WriteLine($"Estudiante 1: {Est1.Nombre}");
            Console.WriteLine($"Estudiante 2 {Est2.Nombre}");
            Console.WriteLine($"Estudiante 1: {Est3.Nombre}");

        }
    }
}
