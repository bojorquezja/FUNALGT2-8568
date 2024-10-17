using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personas;


namespace Personas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Estudiante est = new Estudiante();

            Console.Write("Ingrese el nombre del estudiante: ");
            est.Nom = Console.ReadLine();

            Console.Write("Ingrese la edad del estudiante: ");
            est.Edad = int.Parse(Console.ReadLine());
            
            Console.WriteLine(est);
            est.Corre();
            est.Estudia();
            
            Entrenador entre = new Entrenador();

            Console.Write("Ingrese el nombre del entrenador: ");
            entre.Nom = Console.ReadLine();

            Console.Write("Ingrese el deporte del entrenador: ");
            entre.Dep = Console.ReadLine();

            Console.WriteLine(entre);
            entre.HaceEjercicio();
            entre.EntrenaEstudiantes();
        }
    }
}
