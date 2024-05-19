using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANdersonRepaso
{
 public class ProgramacionEstructurada2
  {
    public static void Ejecutar() {
      //using System.Globalization;


      Console.WriteLine("Declaracionm de variables como object");

      String variable = "Hola";
      dynamic cualquiercosa = 4345f;
      Console.WriteLine("El valor para cualquier variable cosa es de {0}", variable);
      Console.WriteLine("La variable 'Cualquier cosa' tiene  {0} caracteres", cualquiercosa.ToString().Length);
    }

  }
}
