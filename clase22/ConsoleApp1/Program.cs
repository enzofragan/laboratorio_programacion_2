using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Alumnos;
using Entidades.Externa;
using Entidades.Externa.Sellada;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      ESexo hombre = ESexo.Masculino;
      Persona p1 = new Persona("juan", "romeo", 18, hombre);
     
    }
  }
}
