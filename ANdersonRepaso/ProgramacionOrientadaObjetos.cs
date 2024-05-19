using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANdersonRepaso
{
  public class ProgramacionOrientadaObjetos
  {
    public static void Ejecutar() {
      var persona = new Persona();
      Console.WriteLine("Ingresa tu nombre");
      persona.name = Console.ReadLine();
      Separador();
      Console.WriteLine("Ingresa tu Apellido");
      persona.Apellido = Console.ReadLine();
      Separador();
       
      Console.WriteLine("Ingresa tu Salario");
      if(float.TryParse(Console.ReadLine(),out var salario))
      {
        persona.Salario = salario;
      }
      else
      {
        Mensaje("El Valor del Salario no es el Correcto", true);
        persona.Salario = 1000;
      }
      Console.WriteLine("Ingresa tu Fecha de Nacimiento");
      if(DateTime.TryParse(Console.ReadLine(),out var fechaNacimiento))
      {
        persona.FechaNacimiento = fechaNacimiento;
      }
      else
      {
        Mensaje("La fecha de Nacimiento no es correcta: "+true);
        persona.FechaNacimiento = DateTime.Today.AddYears(-30);
      }
      var mensaje = @$"Los datos son Nombre: {persona.name}
                                     Apellido: {persona.Apellido}
                                     Salario: {persona.Salario:N2}
                                     Fecha de Nacimiento {persona.FechaNacimiento:D}";
       
      Mensaje(mensaje);
    }
    private static void Separador() {
      Console.WriteLine(new String('ª', 60));
    }

    private static void Mensaje(String mensaje, bool error=false) {
      Console.ForegroundColor = error ? ConsoleColor.Red : ConsoleColor.Cyan;
      Console.WriteLine(mensaje);
    }
  }
}
