using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Colegio;

namespace Colegio
{
    public class Salon
    {
        public Entrenador Ent { get; set; }
        public Estudiantes Est1 { get; set; }
        public Estudiantes Est2 { get; set; }
        

        public void pasarAsistencia() {
            Console.WriteLine($"Entrenador: {Ent1.Nombre}");
            Console.WriteLine($"Estudiante 1: {Est1.Nombre}");
            Console.WriteLine($"Estudiante 2 {Est2.Nombre}");
            Console.WriteLine($"Estudiante 1: {Est3.Nombre}");

        }
        // ignorar esto

    }
}
