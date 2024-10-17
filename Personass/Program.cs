using nousar.Personas;
using Personas;
using static nousar.Personas.Salon;
Salon salon = new Salon();
Console.WriteLine("Ingrese el nombre del primer estudiante");
Estudiante e1 = new Estudiante();
e1.Nombre = Console.ReadLine();
e1.Edad = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el nombre del segundo estudiante");
Estudiante e2 = new Estudiante();
e2.Nombre = Console.ReadLine();
e2.Edad = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el nombre del tercer estudiante");
Estudiante e3 = new Estudiante();
e3.Nombre = Console.ReadLine();
e3.Edad = int.Parse(Console.ReadLine());
Console.WriteLine("Alumnos asignados al salon correspondiente");

Console.WriteLine("Ingresa el nombre del entrenador");
Entrenador en1 = new Entrenador();
en1.Nombre = Console.ReadLine();
Console.WriteLine("Ingrese la edad del entrenador");

salon.Estu1 = e1;
salon.Estu2 = e2;
salon.Estu3 = e3;
salon.Entr1 = en1;

salon.Pasarlista();
e1.Estudia();
en1.Haceejercicio();