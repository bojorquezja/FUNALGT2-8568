﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegio
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public string Edad{ get; set; }

        public void Corre()
        {
            Console.WriteLine("Es un metodo publico y vacio sin parametros = Corre");
            Console.WriteLine(ToString());

        }
        public void Estudia()
        {
            Console.WriteLine("Es un metodo publico y vacio sin parametros = Estudia");
            Console.WriteLine(ToString());


        }



    }
}
