using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public  class Entrenador
    {
       public string Nombre { get; set; }
       public string Deporte{ get; set; }

        public void HacerEjercicio()
        {
            Console.WriteLine("Es un metodo publico y vacio sin parametros = HacerEjercicios");
            Console.WriteLine(ToString());

        }
        public void EntrenaEstudio()
        {
            Console.WriteLine("Es un metodo publico y vacio sin parametros = EntrenaEstudio");
            Console.WriteLine(ToString());



        }
    }
}
