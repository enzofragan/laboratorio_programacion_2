using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase5.entidades;

namespace clase5.test
{
  class Program
  {
    static void Main(string[] args)
    {
      tinta tinta1 = new tinta();
      tinta tinta2 = new tinta(ConsoleColor.Blue);
      tinta tinta3 = new tinta(ConsoleColor.DarkGreen,ETipoTinta.conBrillo);

      Console.WriteLine(tinta.mostrar(tinta1));
      Console.WriteLine(tinta.mostrar(tinta2));
      Console.WriteLine(tinta.mostrar(tinta3));

      Console.ReadKey();
    }
  }
}
