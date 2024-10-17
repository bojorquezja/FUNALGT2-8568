using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class Entrenador
    {
        public string Nombre { get; set; }
        public string Deporte { get; set; }

        public void HaceEjercicio() {
            Console.WriteLine("Entreno para estar mas saludable !");
        }
        public void EntrenaEstudiantes()
        {
            Console.WriteLine("Con mas fuerza! denle animo!");
        }

    }
}
