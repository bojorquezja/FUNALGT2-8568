using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cole
{
    internal class ESTUDIANTES 
    {
        public string Direccion { get; set; }
        public Delfin Delfin1 { get; set; }
        public Delfin Delfin2 { get; set; }
        public Orca Orca1 { get; set; }
        public Orca Orca2 { get; set; }

        public void ListaNombres()
        {
            Console.WriteLine($"Nombre: {Delfin1.Nombre}");
            Console.WriteLine($"Edad: {Delfin2.Nombre}");
            Console.WriteLine($"Nombre: {Orca1.Nombre}");
            Console.WriteLine($"Deporte: {Orca2.Nombre}");
        }
    }
}
