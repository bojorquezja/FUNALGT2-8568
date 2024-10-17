using Colegio;
using Personas;

Console.WriteLine("----------Menu de opciones----------");
Console.WriteLine("\n1. Ingresar estudiantes\n 2. Ingresar entrenador \n 3. Mostrar salon y personas \n 4. Fin");

int opcion = Convert.ToInt32(Console.ReadLine());
Salon s = new Salon();
Estudiantes e1 = new Estudiantes();
Estudiantes e2 = new Estudiantes();
Estudiantes e3 = new Estudiantes();
Entrenador ent1 = new Entrenador();

Console.Clear();
switch (opcion)
{
    case 1:
        Console.Write("Estudiante 1 \nNombre: ");
        e1.Nombre = Console.ReadLine();
        Console.Write("Edad: ");
        e1.Edad = Console.ReadLine();
        Console.Write("Estudiante 2 \nNombre: ");
        e2.Nombre = Console.ReadLine();
        Console.Write("Edad: ");
        e2.Edad = Console.ReadLine();
        Console.Write("Estudiante 3 \nNombre: ");
        e3.Nombre = Console.ReadLine();
        Console.Write("Edad: ");
        e3.Edad = Console.ReadLine();
        break;
    case 2:
        Console.Write("Entrenador \nNombre: ");
        ent1.Nombre = Console.ReadLine();
        Console.Write("Deporte: ");
        ent1.Deporte = Console.ReadLine();
        break;
    case 3:
        break;
    case 4:
        break;
}