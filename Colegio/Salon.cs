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

        Estudiante e1 = new Estudiante();
        Estudiante e2 = new Estudiante();
        Estudiante e3 = new Estudiante();

        public void PasarAsistencia() {
            Console.WriteLine($"Asistencia:{e1.Nombre}");
        }
    }
}
