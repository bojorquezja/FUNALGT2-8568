using Colegio;
using Personas;


namespace Colegio { 
    public class Program { 
        static void Main(string[] args) { 
int opcion = Convert.ToInt32(Console.ReadLine());
Salon s = new Salon();
Estudiantes e1 = new Estudiantes();
Estudiantes e2 = new Estudiantes();
Estudiantes e3 = new Estudiantes();
Entrenador ent1 = new Entrenador();
do
{
    Console.WriteLine("----------Menu de opciones----------");
    Console.WriteLine("\n1. Ingresar estudiantes\n 2. Ingresar entrenador \n 3. Mostrar salon y personas \n 4. Fin");

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

            s.Estudiante1 = e1;
            s.Estudiante2 = e2;
            s.Estudiante3 = e3;
                        break;
        case 2:
            Console.Write("Entrenador \nNombre: ");
            ent1.Nombre = Console.ReadLine();
            Console.Write("Deporte: ");
            ent1.Deporte = Console.ReadLine();

            s.Entrenador1 = ent1;
            break;
        case 3:
            s.PasarAsistencia();
            s.Estudiante1.Estudia();
            s.Entrenador1.HacerEjercicio();
            break;
        case 4:
            break;
    }

    

} while (opcion != 4) ;
}
}
}