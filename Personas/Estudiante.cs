using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class Estudiante
    {
        public string Name { get; set; }
        public int Edad { get; set; }
        public void Corre()
        {
            Console.WriteLine("CORRE");
        }
        public void Estudia()
        {
            Console.WriteLine("ESTUDIA");
        }
        public void ToString()
        {
            Console.WriteLine("El nombre es " + Name);
            Console.WriteLine("La edad es " + Edad);
        }
    }
}
