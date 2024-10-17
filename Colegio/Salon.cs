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
        public Entrenador Eu { get; set; }
        public Estudiante E1 { get; set; }
        public Estudiante E2 { get; set; }
        public Estudiante E3 { get; set; }
        public void PasarAsistencia()
        {
            Console.WriteLine("HOLA " + Eu.Name);
            Console.WriteLine("HOLA " + E1.Name);
            Console.WriteLine("HOLA " + E2.Name);
            Console.WriteLine("HOLA " + E3.Name);
        }

    }
    

}