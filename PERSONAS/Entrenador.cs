using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PERSONAS
{
    internal class Entrenador
    {
        public string Nombre { get; set; }
        public string Deporte { get; set; }

        public void Hacerejercicio()
        {
            Console.WriteLine("El entrenador hace ejercicio");
        }

        public void Entrenaestudiantes()
        {
            Console.WriteLine("El entrenador entrena a los estudiantes");
        }



    }
}
