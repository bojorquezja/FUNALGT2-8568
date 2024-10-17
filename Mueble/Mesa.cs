using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mueble
{
    public class Mesa
    {
        public string Color { get; set; }
        public int Largo { get; set; }
        public void ServirComida()
        {
            Console.WriteLine("Preparando los platos");
        }
        public void TenderMantel()
        {
            Console.WriteLine("Tendiendo el mantel navideño");
        }
    }
}
