using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase_04;

namespace clase04.test
{
  class Program
  {
    static void Main(string[] args)
    {
      cosa obj = new cosa();
      cosa obj2 = new cosa(10);
      cosa obj3 = new cosa(10, DateTime.Now);
      cosa obj4 = new cosa(10, DateTime.Now, "Sin valor");

      Console.WriteLine("mostrar obj2");
      Console.WriteLine(obj2.mostrar());
      Console.ReadLine();

      Console.WriteLine("mostrar obj3");
      Console.WriteLine(obj3.mostrar());
      Console.ReadLine();

      Console.WriteLine("mostrar obj4");
      Console.WriteLine(obj4.mostrar());
      Console.ReadLine();

      Console.WriteLine("mostrar por defecto");
      obj.establecerValorI(5);
      obj.establecerValorS("juan");
      obj.establecerValorD(DateTime.Now);

      Console.WriteLine(obj.mostrar());
      Console.WriteLine(cosa.mostrar(obj));
      Console.ReadLine();
    }
  }
}
