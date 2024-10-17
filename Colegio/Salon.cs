using Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio
{
    internal class Salon
    {
        public Entrenador Entrenador1 { get; set; }
        public Estudiantes Estudiante1 { get; set; }
        public Estudiantes Estudiante2 { get; set; }
        public Estudiantes Estudiante3 { get; set; }

        public void PasarAsistencia()
        {
            Console.WriteLine(Entrenador1.Nombre);
            Console.WriteLine(Estudiante1.Nombre);
            Console.WriteLine(Estudiante2.Nombre);
            Console.WriteLine(Estudiante3.Nombre);
        }

    }
}
