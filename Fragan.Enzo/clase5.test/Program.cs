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
      Tinta tinta1 = new Tinta();
      Tinta tinta2 = new Tinta(ConsoleColor.Blue);
      Tinta tinta3 = new Tinta(ConsoleColor.DarkGreen,ETipoTinta.conBrillo);
      Tinta tinta4 = new Tinta();
      Tinta tinta5 = tinta1;
      Pluma pluma1 = new Pluma("mapel",tinta3,50);
      Pluma pluma2 = new Pluma("tenkel", tinta2, 10);


      /*if(tinta1!=tinta4)//tinta1.Equals(tinta4)
      {
        Console.WriteLine("son iguales");
      }
      else
      {
        Console.WriteLine("no son iguales");
      }

      Console.WriteLine(Tinta.mostrar(tinta1));
      Console.WriteLine(Tinta.mostrar(tinta2));
      Console.WriteLine(Tinta.mostrar(tinta3));*/

      Console.WriteLine(pluma1);

      pluma2 = pluma2 + tinta2;

      Console.WriteLine(pluma2);
      Console.ReadKey();
    }
  }
}
