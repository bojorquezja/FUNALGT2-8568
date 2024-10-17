using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nousar
{
    public  class Entrenador
    {
        public string Nombre { get; set; }
        public string Deporte { get; set; }

        public void HaceEjercicio()
        {
            Console.WriteLine("Hacer ejercicio es muy bueno a la salud");
        }
        public void EntrenaEstudiante()
        {
            Console.WriteLine("Entrenar es lo mejor para mejorar");
        }
        public void Tostring()
        {
            Console.WriteLine($"\nEl entrenador es: {Nombre} y su frase(o lema) es: {Deporte}");
            
        }

    }
}
