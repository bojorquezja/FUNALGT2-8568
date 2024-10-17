using Personas;
Salon s = new Salon();
Console.WriteLine("Ingrese el nombre del primer estudiante: ");
Estudiante estudiante1 = new Estudiante();
estudiante1.Nombre = Console.ReadLine();
Console.WriteLine("Ingrese la edad del primer estudiante");
estudiante1.Edad =int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el nombre del segundo estudiante: ");
Estudiante estudiante2 = new Estudiante();
estudiante2.Nombre = Console.ReadLine();
Console.WriteLine("Ingrese la edad del segundo estudiante");
estudiante2.Edad = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la edad del tercer estudiante");
Estudiante estudiante3 = new Estudiante();
estudiante3.Nombre = Console.ReadLine();
Console.WriteLine("Ingrese la edad del tercer estudiante");
estudiante3.Edad = int.Parse(Console.ReadLine()) ;
Console.WriteLine("Alumnos asignados al salon correctamente");
Console.ReadKey();
Console.WriteLine("Ingrese el nombre del Entrenador: ");
Entrenador entrenador1 = new Entrenador();
entrenador1.Nombre = Console.ReadLine();
Console.WriteLine("Ingrese la edad del entrenador: ");
entrenador1.Edad= int.Parse(Console.ReadLine());
Console.WriteLine("Entrenador asignado al Salon correctamente");
Console.ReadKey();


s.Est1 = estudiante1;

s.Est2 = estudiante2;

s.Est3 = estudiante3;

s.Ent1 = entrenador1;
Console.WriteLine("///////////////////////////////////////");
s.pasarAsistencia();
Console.WriteLine("///////////////////////////////////////");
estudiante1.Estudia();
entrenador1.HaceEjercicio();


