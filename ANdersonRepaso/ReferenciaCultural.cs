using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANdersonRepaso
{
  public static class ReferenciaCultural
  {
    public static void Establecer(string referencia)
    {
      if (string.IsNullOrEmpty(referencia))
      {
        referencia = "es-Mx";
      }
      else {
        var existeCaracter = referencia.Contains("-");
        if (!existeCaracter) {
          referencia = "es-CO";
        }
       
      }
      System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(referencia);
      Console.WriteLine("Se establecio una referencia a {0}", Thread.CurrentThread.CurrentCulture.DisplayName);
    }

  }
}
