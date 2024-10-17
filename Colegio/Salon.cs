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
        public Entrenador Entrenador { get; set; }
        public Estudiante[] Estudiantes { get; set; } = new Estudiante[3];

        public void PasarAsistencia()
        {
            Console.WriteLine($"Entrenador: {Entrenador.Nom}");
            for (int i = 0; i < Estudiantes.Length; i++)
            {
                Console.WriteLine($"Estudiante {i + 1}: {Estudiantes[i].Nom}");
            }
        }

    }
}

