// See https://aka.ms/new-console-template for more information
using nousar;

Estudiante es1 = new Estudiante();
Estudiante es2 = new Estudiante();
Estudiante es3 = new Estudiante();
Estudiante salon1 = new Estudiante();
Entrenador en1 = new Entrenador();
Entrenador curso1 = new Entrenador();



string Estud1, Estud2, Estud3, Entrenador, depor;
int edad1, edad2, edad3;

Console.Write("Ingrese el nombre del estidiante 1: ");
Estud1 = Console.ReadLine();
Console.Write("\nAhora su edad: ");
edad1 = int.Parse(Console.ReadLine());
Console.Write("\nIngrese el nombre del estidiante 2: ");
Estud2 = Console.ReadLine();
Console.Write("\nAhora su edad: ");
edad2 = int.Parse(Console.ReadLine());
Console.Write("\nIngrese el nombre del estidiante 3: ");
Estud3 = Console.ReadLine();
Console.Write("\nAhora su edad: ");
edad3 = int.Parse(Console.ReadLine());

Console.Write("\nIngrese el nobmre del entrenador:");
Entrenador = Console.ReadLine();
Console.Write("\nIngrese lo que enseña el entrenador (entrena o hace ejercicio): ");
depor = Console.ReadLine().ToLower();

Salon sl = new Salon();
es1.Nombre = Estud1;
es1.Edad = edad1;
es2.Nombre = Estud2;
es2.Edad = edad2;
es3.Nombre = Estud3;
es3.Edad = edad3;
en1.Nombre = Entrenador;
en1.Deporte = depor;
sl.PasaAsistencia();

if (depor == "ejercicio" || depor == "hace ejercicio")
{
    Console.WriteLine(salon1.Corre);
    Console.WriteLine(curso1.HaceEjercicio);
}
else if (depor == "entrena")
{
    Console.WriteLine(salon1.Estudia);
    Console.WriteLine(curso1.EntrenaEstudiante);
}
Console.ReadKey();


