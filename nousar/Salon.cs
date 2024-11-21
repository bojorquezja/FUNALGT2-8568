using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace nousar
{
    
    public class Salon
    {
        public Estudiante es1 {  get; set; }

        public Estudiante es2 { get; set; }

        public Estudiante es3 { get; set; }

        public Entrenador en1 {  get; set; }

        public void PasaAsistencia()
        {
            Console.WriteLine($"Estudiante: {es1.Nombre} y su edad es {es1.Edad}");
            Console.WriteLine($"Estudiante: {es2.Nombre} y su edad es {es2.Edad}");
            Console.WriteLine($"Estudiante: {es3.Nombre} y su edad es {es3.Edad}");
            Console.WriteLine($"\nEl entrenador es: {en1.Nombre} y su frase(o lema) es: {en1.Deporte}");



        }
    }
}
