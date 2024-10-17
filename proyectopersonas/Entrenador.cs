using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_personas
{
    public class Entrenador
    {
        public string Nombre { get; set; }
        public string Deporte { get; set; }

        public void Haceejericios () 
        {
            Console.WriteLine("Miren atentos el ejercicio..");
        }

        public void Entrenaestudiantes()
        {
            Console.WriteLine("Vamos a practicar atletismo.");
        }
                

    }
}
