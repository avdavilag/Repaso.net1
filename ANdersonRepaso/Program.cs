using ANdersonRepaso;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("ASP WEB DEVELOPER - Galaxy Trainig");
Console.WriteLine(new string ('-',60));
//ProgramacionEstructurada2.Ejecutar();
//ProgramacionOrientadaObjetos.Ejecutar();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Establece la referencia cultura de la aplicacion");
Console.ForegroundColor = ConsoleColor.Green;
ReferenciaCultural.Establecer(Console.ReadLine()!);


Console.WriteLine("!!!! Escoge una opcion por favor !!!!!");
Console.WriteLine("1. Programacion Estructurada");
Console.WriteLine("2. Programacion Orientada a Objetos");

if(int.TryParse(Console.ReadLine(), out var opcion))
{
  switch (opcion)
  {
    case 1:
      ProgramacionEstructurada2.Ejecutar();
      break;
    case 2:
      ProgramacionOrientadaObjetos.Ejecutar();
      break;
      default:
      Console.WriteLine("Opcion Incorrecta");
      break;
    
  }
}
Console.WriteLine(new string('-',60));
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Fin del Programa");
