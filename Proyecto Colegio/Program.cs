using Proyecto_Colegio;
using System.ComponentModel;

Console.WriteLine("Bienvenido a salon");
Console.WriteLine("INGRESE OPCIÓN:");
int opcion=int.Parse(Console.ReadLine());
int estu = 3;
do
{
    Console.WriteLine("Ingrese nuevamente.");
    do
    {
        Console.WriteLine($"1. Estudiantes:");
        Console.WriteLine($"2. Entrenador: ");
        Console.WriteLine($"3. Muestra Salón y Personas: ");
        Console.WriteLine("4. Fin");
    Console.Clear();
        switch (opcion)
        {
            case 1:do
                {
                   Console.WriteLine( "Ingrese nombre del estudiante: ");
                        estudiante = Console.ReadLine();
                } while (estu < 4);
                        break;
                case 2:break;
                case 3:break;
                case 4:break;
        }

    } while (opcion < 5 || opcion > 0);

}while (opcion<0||opcion>4);







