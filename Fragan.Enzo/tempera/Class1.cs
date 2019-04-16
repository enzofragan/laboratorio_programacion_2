using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase6
{
    public class Tempera
    {
        private ConsoleColor _color;
        private string _marca;
        private sbyte _cantidad;

        private string mostrar()
        {
            return "marca: " + this._marca + "\ncolor: " + this._color.ToString() + "\ncantidad: " + this._cantidad.ToString();
        }

        public static string mostrar(Tempera Tempera1)
        {
            string ret = "";
            if(Tempera1 != null)
            {
                ret = Tempera1.mostrar();
            }
            return ret;
        }

        public static bool operator ==(Tempera Tempera1, Tempera Tempera2)
        {
            bool respuesta = false;
            
            if(Tempera1 != null && Tempera2 != null)
            {
                respuesta = (Tempera1._marca==Tempera2._marca)&&(Tempera1._color==Tempera2._color);
            }

            return respuesta;
        }

        public static bool operator !=(Tempera Tempera1, Tempera Tempera2)
        {
            return !(Tempera1 == Tempera2);
        }

        public static Tempera operator +(Tempera Tempera1, sbyte cantidad)
        {
            Tempera1._cantidad += cantidad;
            return Tempera1;
        }

        public static Tempera operator +(Tempera Tempera1,Tempera Tempera2)
        {
            Tempera Tempera3 = new Tempera(Tempera1._marca, Tempera1._color, Tempera1._cantidad);
            if (Tempera1==Tempera2)
            {
              Tempera3 += Tempera2._cantidad;
            }

            return Tempera3;
        }

        public static explicit operator sbyte(Tempera Tempera1)
        {
            return Tempera1._cantidad;
        }

        public static implicit operator string(Tempera Tempera1)
        {
          return Tempera1.mostrar();
        }

        public Tempera() : this("sin marca",ConsoleColor.Black,10)
        {

        }

        public Tempera(string marca) : this(marca, ConsoleColor.Black,10)
        {
            this._marca = marca;
        }

        public Tempera(string marca, ConsoleColor color) : this(marca,color,10)
        {
            this._marca = marca;
            this._color = color;
        }

        public Tempera(string marca, ConsoleColor color, sbyte cantidad)
        {
            this._marca = marca;
            this._color = color;
            this._cantidad = cantidad;
        }
    }
}
