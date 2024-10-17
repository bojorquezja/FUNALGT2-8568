using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class Entrenador
    {
        public string Nombre { get; set; }
        public string Deporte { get; set; }

        public void HaceEjercicio() {
            Console.WriteLine("El entrenador empieza con el entrenamiento");

        }
        public void EntrenaEstudiantes() {
            Console.WriteLine("El entrenador empieza a practicar con los estudiantes");
        }
    }
}
