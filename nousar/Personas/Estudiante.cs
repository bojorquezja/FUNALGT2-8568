using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nousar
{
    public class Estudiante
    {
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public void Corre()
        {
            Console.WriteLine("Mira lo rapido que voy");
        }

        public void Estudia()
        {
            Console.WriteLine("Soy el futuro");
        }
        
    }
}
