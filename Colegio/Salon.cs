using Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio
{
    public class Salon
    {
        public Entrenador Entrenador1 { get; set; }
        public Estudiantes Estudiante1 { get; set; }
        public Estudiantes Estudiante2 { get; set; }
        public Estudiantes Estudiante3 { get; set; }

        public void PasarAsistencia()
        {
            Console.WriteLine($"Entrenador \n Nombre: {Entrenador1.Nombre} \n Deporte: {Entrenador1.Deporte}");
            Console.WriteLine($"Estudiante 1 \n Nombre: {Estudiante1.Nombre} \n Edad: {Estudiante1.Edad}");
            Console.WriteLine($"Estudiante 2 \n Nombre: {Estudiante2.Nombre} \n Edad: {Estudiante2.Edad}");
            Console.WriteLine($"Estudiante 3 \n Nombre:  {Estudiante3.Nombre} \n Edad: {Estudiante3.Edad}");
        }

    }
}
