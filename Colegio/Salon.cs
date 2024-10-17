using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personas;

namespace Colegio
{
    public class Salon
    {
        
        public Estudiante Estudiante1 { get; set; }
        public Estudiante Estudiante2 { get; set; }
        public Estudiante Estudiante3 { get; set; }

        public Entrenador E { get; set; }

        public void PasarAsistencia() {
            Console.WriteLine($"Asistencia:\n{Estudiante1.Nombre}");
            Console.WriteLine($"{Estudiante2.Nombre}");
            Console.WriteLine($"{Estudiante3.Nombre}");
            Console.WriteLine($"Profesor: {E.Nombre}");

            Console.Write($"El estudiante {Estudiante1.Nombre} "); 
        }
    }
}
