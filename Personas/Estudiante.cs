using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class Estudiante
    {
     public int Nombre { get; set; }
        public string Edad {  get; set; }
        public void Correr()
        {
            Console.WriteLine("Yo corro muy rápido!");
        }
        public void Estudia()
        {
            Console.WriteLine("Yo estudio mucho!");
        }
    }
}
