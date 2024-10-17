using Personas; 

namespace Colegio
{
    class Program
    {
        static void Main(string[] args)
        {
            Salon salon = new Salon();
            int opcion;

            do
            {
                Console.WriteLine("Menu de Opciones:");
                Console.WriteLine("1. Ingresar Estudiantes");
                Console.WriteLine("2. Ingresar Entrenador");
                Console.WriteLine("3. Mostrar Salon y Personas");
                Console.WriteLine("4. Fin");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        IngresarEstudiantes(salon);
                        break;
                    case 2:
                        IngresarEntrenador(salon);
                        break;
                    case 3:
                        MostrarSalon(salon);
                        break;
                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intente de nuevo.");
                        break;
                }

            } while (opcion != 4);
        }

        static void IngresarEstudiantes(Salon salon)
        {
            for (int i = 0; i < 3; i++)
            {
                Estudiante estudiante = new Estudiante();
                Console.Write($"Ingrese el nombre del estudiante {i + 1}: ");
                estudiante.Nom = Console.ReadLine();
                Console.Write($"Ingrese la edad del estudiante {i + 1}: ");
                estudiante.Edad = int.Parse(Console.ReadLine());
                salon.Estudiantes[i] = estudiante;
            }
        }

        static void IngresarEntrenador(Salon salon)
        {
            Entrenador entrenador = new Entrenador();
            Console.Write("Ingrese el nombre del entrenador: ");
            entrenador.Nom = Console.ReadLine();
            Console.Write("Ingrese el deporte del entrenador: ");
            entrenador.Dep = Console.ReadLine();
            salon.Entrenador = entrenador;
        }

        static void MostrarSalon(Salon salon)
        {
            salon.PasarAsistencia();
            salon.Estudiantes[0].Estudia();
            salon.Entrenador.HaceEjercicio();
        }
    }
}
