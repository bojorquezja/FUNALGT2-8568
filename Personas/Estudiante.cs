﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    internal class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public void Corre()
        {
            Console.WriteLine("El estudiante corre");
        }

        public void Estudia() {
            Console.WriteLine("El estudiante empezó a estudiar");
        }







    }
}
