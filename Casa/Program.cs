// See https://aka.ms/new-console-template for more information

using System.Drawing;
using Casa;
using Mueble;

string n1, n2, n3;

Console.WriteLine("******************************");
Console.WriteLine("\n\tBienvenido\n");
Console.WriteLine("******************************");

Console.Write("Ingresar nombre completo del estudiante N°1: ");
n1 = Console.ReadLine();
Console.Write("Ingresar nombre completo del estudiante N°2: ");
n2 = Console.ReadLine();
Console.Write("Ingresar nombre completo del estudiante N°3: ");
n3 = Console.ReadLine();

Console.Clear();

Sala.Listar();
Console.WriteLine("");
Console.WriteLine("******************************");
Console.WriteLine("\tAlumno N°1: " + n1);
Console.WriteLine("\tAlumno N°2: " + n2);
Console.WriteLine("\tAlumno N°3: " + n3);
Console.WriteLine("******************************");

//Silla.Sentarse(); (falla)

//Mesa.ServirComida(); (falla)

//Profe no entendí las inidicaciones del program :(