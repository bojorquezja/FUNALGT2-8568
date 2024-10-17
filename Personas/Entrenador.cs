using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class Entrenador
    {
        public string Deporte { get; set; }
        public string Name { get; set; }
        public void HaceEjercicio()
        {
            Console.WriteLine("HACE EJERCICIO");
        }
        public void EntrenaEstudiantes()
        {
            Console.WriteLine("ENTRENA ESTUDIANTES");
        }
        public void ToString()
        {

        }
    }
}
