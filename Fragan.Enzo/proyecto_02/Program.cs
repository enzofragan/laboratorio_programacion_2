using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje="hola";
            Sello.color = ConsoleColor.DarkRed;
            System.Console.WriteLine(Sello.Imprimir());
            Sello.imprimirColor();
            Sello.Borrar();
            System.Console.WriteLine(Sello.Imprimir());
            System.Console.ReadKey();
        }
    }
}
