using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_02
{
    public class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;
        public static string Imprimir()
        {
            return Sello.ArmarFormatoMensaje();
        }
        public static void Borrar()
        {
            Sello.mensaje = "";
        }
        public static void imprimirColor()
        {
            Console.ForegroundColor = color;
            System.Console.WriteLine(Sello.Imprimir());
            Console.ForegroundColor = ConsoleColor.DarkGray;
            System.Console.WriteLine(Sello.Imprimir());
        }

        static string ArmarFormatoMensaje()
        {
            string formato="";
            int contador;
            if(Sello.mensaje.Length>0)
            {
                contador = Sello.mensaje.Length + 2;
            }
            else
            {
                contador = 0;
            }

            for(int i=0;i<contador;i++)
            {
                formato += "*";
            }

            formato += "\n*" + Sello.mensaje + "*\n" + formato;

            return formato;
        }

    }
}
