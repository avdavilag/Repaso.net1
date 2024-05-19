using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANdersonRepaso;

  internal class Persona
  {
    public String name { get; set; } = null!;
    public String Apellido { get; set; } = default;

    public String Direccion { get; set; } = String.Empty!;

   
    public DateTime FechaNacimiento { get; set; }
    public float Salario { get; set; }
    
  }

public class OtraClase
{

}
