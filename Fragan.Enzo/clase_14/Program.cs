using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_14
{
  class Program
  {
    static void Main(string[] args)
    {
      int numero;
      Console.WriteLine("ingrese un numero: ");
      numero = parseadoraDeEnteros.Parse(Console.ReadLine());
      Console.WriteLine(numero.ToString());
      Console.ReadLine();
    }
  }
}
