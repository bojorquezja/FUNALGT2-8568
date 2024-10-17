using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mueble
{
    public class Silla
    {
        public string Color { get; set; }
        public string Material { get; set; }

        public void Sentarse()
        {
            Console.WriteLine("Flexionando rodillas");
        }
        public void Moverse()
        {
            Console.WriteLine("Estirando las piernas");
        }
    }
}
