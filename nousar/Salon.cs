using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nousar
{
    
    internal class Salon
    {
        public Estudiante es1 {  get; set; }

        public Estudiante es2 { get; set; }

        public Estudiante es3 { get; set; }

        public Entrenador en1 {  get; set; }

        public void PasaAsistencia()
        {
            Console.WriteLine(es1.ToString());
            Console.WriteLine(es2.ToString());
            Console.WriteLine(es3.ToString());
            Console.WriteLine(en1.ToString());



        }
    }
}
