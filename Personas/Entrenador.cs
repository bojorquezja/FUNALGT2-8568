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

        public void HacerEjercicio()
        {
            Console.WriteLine("Entrenando dia y noche");
        }
        public void EntrenaEstudiantes()
        {
            Console.WriteLine("Para los juegos olimpicos");
        }
    }
}
