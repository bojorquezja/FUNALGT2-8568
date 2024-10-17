using Colegio;
using Personas;

Salon a = new Salon();

Estudiante e1 = new Estudiante();
Estudiante e2 = new Estudiante();
Estudiante e3 = new Estudiante();

Entrenador E = new Entrenador();

Console.WriteLine("Ingrese el nombre del estudiante 1");

e1.Nombre = Console.ReadLine();
Console.WriteLine("Ingrese su edad");
e1.Edad = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el nombre del estudiante 2");

e2.Nombre = Console.ReadLine();
Console.WriteLine("Ingrese su edad");
e2.Edad = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el nombre del estudiante 3");

e3.Nombre = Console.ReadLine();
Console.WriteLine("Ingrese su edad");
e3.Edad = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el nombre del Entrenador");
E.Nombre = Console.ReadLine();
Console.WriteLine("Ingrese el deporte del profesor");
E.Deporte = Console.ReadLine();

a.Estudiante1 = e1;
a.Estudiante2 = e2;
a.Estudiante3 = e3;

a.E = E;

a.PasarAsistencia();
