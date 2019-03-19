using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Title = "ejercicio 1";
            int numero;
            int i;
            float contador = 0;
            float promedio;
            int mayor = 0;
            int menor = 0;
            int total = 5;

            for(i=0;i<total;i++)
            {
                System.Console.Write("ingrese un numero:");
                numero = int.Parse(System.Console.ReadLine());
                if(i==0)
                {
                    mayor = numero;
                    menor = numero;
                }
                else
                {
                    if (numero > mayor)
                    {
                        mayor = numero;
                    }
                    if (numero < menor)
                    {
                        menor = numero;
                    }
                }
                contador = contador + numero;
            }

            promedio = contador / total;

            System.Console.WriteLine("el total es: {0} ", contador);
            System.Console.ReadLine();
            System.Console.WriteLine("el promedio es: {0:#,###.00} ", promedio);
            System.Console.ReadLine();
            System.Console.WriteLine("el maximo es: {0} ", mayor);
            System.Console.ReadLine();
            System.Console.WriteLine("el minimo es: {0} ", menor);
            System.Console.ReadKey();
        }
    }
}
