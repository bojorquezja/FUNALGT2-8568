using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Estudiante
    {
        public void Corre()
        {
            int edad;
            string nombre;
            Console.WriteLine("Cual es tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Cuantos años tienes: ");
            edad=int.Parse(Console.ReadLine());
            Console.WriteLine("Correr es bueno para la salud");
        }
        public void Estudia() 
        { 
         Console.WriteLine("Estudiar alimenta nuestra mente");
        }
         
    }
    public class Entrenador 
    {
        public void HaceEjercicio()
        {
            Console.WriteLine("Los estudiantes hacen ejercicios");
        }
        public void EntrenaEstudiantes()
        {
            Console.WriteLine("Los estudiantes entrenan en el colegio");
        }
    }
}
