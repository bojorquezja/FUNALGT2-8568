using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Estudiante(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
        public void Corre()
        {
            Console.WriteLine($"{Nombre} correr le hace bien.");
        }
        public void Estudia()
        {
            Console.WriteLine($"{Nombre} esta estudiando y alimenta su mente.");
        }
        public override string ToString()
        {
            return $"Estudiante: Nombre = {Nombre}, Edad = {Edad}";
        }
    }
    public class Entrenador
    {
        public string Nombre { get; set; }
        public string Deporte { get; set; }
        public Entrenador(string nombre, string deporte)
        {
            Nombre = nombre;
            Deporte = deporte;
        }
        public void HaceEjercicio()
        {
            Console.WriteLine($"{Nombre} le gusta hacer ejercicios haciendo {Deporte}.");
        }
        public void EntrenaEstudiantes()
        {
            Console.WriteLine($"{Nombre} le gusta jugar {Deporte}.");
        }
        public override string ToString()
        {
            return $"Entrenador: Nombre = {Nombre}, Deporte = {Deporte}";
        }
    }
}