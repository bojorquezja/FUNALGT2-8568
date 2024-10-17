using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_personas
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Edad { get; set; }

        public void Corre()
        {
            Console.WriteLine("Estoy corriendoo..");
        }

        public void Estudia()
        {
            Console.WriteLine("Este tema es divertido.");
        }

        public void ToString()
        {
            Console.WriteLine("Ingrese Nombre: ");

            Nombre = Console.ReadLine(); 
        }

    }
}
