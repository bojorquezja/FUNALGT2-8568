using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COLEGIO
{
    public class Salon
    {

        public Estudiante Estudiante1 { get;set }
        public Estudiante Estudiante2 { get;set }
        public Estudiante Estudiante3 { get; set }

        public Entrenador E { get; set }
        public void PasarAsistencia()
        {
            Console.WriteLine($"Profesor:\n{E.Nombre}");

            Console.WriteLine($"El estudiante {Estudiante1.Nombre}");
);
            Console.WriteLine($" {Estudiante2.Nombre }");
            Console.WriteLine($" {Estudiante3.Nombre}");

            

        }

    }
}
