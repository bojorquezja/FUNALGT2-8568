using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class Entrenador
    {
        public string Nom { get; set; }
        public string Dep { get; set; }

        public void HaceEjercicio()
        {
            Console.WriteLine($"{Nom} está haciendo ejercicio.");
        }

        public void EntrenaEstudiantes()
        {
            Console.WriteLine($"{Nom} está entrenando a los estudiantes en el deporte de {Dep}.");
        }

        public override string ToString()
        {
            return $"Nombre: {Nom}, Deporte: {Dep}";
        }
    }
}

