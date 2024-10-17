using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class EstudiantePersonas
    {
        public string Nombre { get; set; }
        public string Edad { get; set; }

        public void Corre()
        {
            Console.WriteLine("Como Usain Bolt");
        }
        public void Estudia()
        {
            Console.WriteLine("Toda la madrugada.");
        }

    }
}
