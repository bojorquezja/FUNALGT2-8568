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
        public void Haceejercicio()
        {
            Console.WriteLine("Nosotros hacemos mucho ejercicio!");
        }
        public void EntrenaEstudiantes()
        {
            Console.WriteLine("Los estudiantes entrenan muy duro para las olimpiadas!");
        }

    }
}
