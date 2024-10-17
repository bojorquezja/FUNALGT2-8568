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
        public Entrenador entrenador1 { get; set; }

        public Estudiante estudiante1 { get; set; }
        public Estudiante estudiante2 { get; set; }
        public Estudiante estudiante3 { get; set; }

        public void PasarAsistencia()
        {
            Console.WriteLine("Estudiante 1 : " + estudiante1.Nombre);
            Console.WriteLine("Estudiante 2 : " + estudiante2.Nombre);
            Console.WriteLine("Estudiante 3 : " + estudiante3.Nombre);
            Console.WriteLine("Edad 1 : " + estudiante3.Nombre);
            Console.WriteLine("Edad 2 : " + estudiante3.Nombre);
            Console.WriteLine("Edad 3 : " + estudiante3.Nombre);
            Console.WriteLine("Entrenador nombre  : " + entrenador1.Nombre);
            Console.WriteLine("Entrenador edad  : " + entrenador1.Nombre);
            
            Entrenador e = new Entrenador();
            Estudiante y  = new Estudiante();
            Console.WriteLine(e);
            Console.WriteLine(y);
            Console.WriteLine(e.ToString());
            Console.WriteLine(y.ToString());
        }
    }
    
}
