using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class Estudiante
    {
        public string Nombre { get; set;  }
        public int Edad { get; set; }

        public void Correr() {
            Console.WriteLine("Que rapido voy");
        }
        public void Estudia() { 
            Console.WriteLine("Estudiando ando");
        }
        
    }
}
