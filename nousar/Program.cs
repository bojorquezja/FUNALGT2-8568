using Personas;

Estudiante estudiante = new Estudiante("Juan", 20);
Console.WriteLine(estudiante.ToString());
estudiante.Corre();
estudiante.Estudia();
Entrenador entrenador = new Entrenador("Carlos", "Fútbol");
Console.WriteLine(entrenador.ToString());
entrenador.HaceEjercicio();
entrenador.EntrenaEstudiantes();