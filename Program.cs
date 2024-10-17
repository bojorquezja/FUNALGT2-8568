// See https://aka.ms/new-console-template for more information
using cole;

Delfin d1 = new Delfin();
d1.Nombre = "Luis";

Delfin d2 = new Delfin();
d2.Nombre = "12 años";

Orca o1 = new Orca();
o1.Nombre = "Marcelo";
Orca o2 = new Orca();
o2.Nombre = "Futbol";

ESTUDIANTES a = new ESTUDIANTES();
a.Direccion = "Av 1";
a.Delfin1 = d1;
a.Delfin2 = d2;
a.Orca1 = o1;
a.Orca2 = o2;
Console.WriteLine(a.Direccion);
a.ListaNombres();
