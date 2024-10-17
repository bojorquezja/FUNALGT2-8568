using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class Estudiante
    {
        public string Nom { get; set; }
        public int Edad { get; set; }

        public void Corre()
        {
            Console.WriteLine($"{Nom} está corriendo.");
        }

        public void Estudia()
        {
            Console.WriteLine($"{Nom} está estudiando.");
        }

        public override string ToString()
        {
            return $"Nombre: {Nom}, Edad: {Edad}";
        }
    }
}

