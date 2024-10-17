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
        Entrenador Eu { get; set; }
        Estudiante E1 { get; set; }
        Estudiante E2 { get; set; }
        Estudiante E3 { get; set; }
        public void PasarAsistencia()
        {
            Console.WriteLine("HOLA " + Eu.Nombre);
            Console.WriteLine("HOLA " + E1.Nombre);
            Console.WriteLine("HOLA " + E2.Nombre);
            Console.WriteLine("HOLA " + E3.Nombre);
        }

    }
    

}