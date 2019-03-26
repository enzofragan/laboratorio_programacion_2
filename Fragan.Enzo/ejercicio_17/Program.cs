using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using boligrafos;

namespace ejercicio_17
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "ejercicio 17";
      Boligrafo boligrafoRojo = new Boligrafo(50,ConsoleColor.Red);
      Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
    }
  }
}
