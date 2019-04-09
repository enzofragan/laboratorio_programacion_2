using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase6
{
    public class Paleta
    {
        private Tempera[]_temperas;
        private int _cantidadMaxima;

        private Paleta() : this(5)
        {
            
        }

        private Paleta(int cantidad)
        {
            this._temperas = new Tempera[cantidad];
            this._cantidadMaxima = cantidad;
        }

        public static implicit operator Paleta(int cantidad)
        {
            return new Paleta(cantidad);
        }

        private string mostrar()
        {
            string retorno = "";
            foreach(Tempera t in this._temperas)
            {
                retorno += Tempera.mostrar(t);
            }

            return retorno;
        }

        public static explicit operator string(Paleta Paleta1)
        {
            return Paleta1.mostrar();
        }

        public static bool operator ==(Paleta paletas,Tempera temperas)
        {
            bool respuesta = false;

            foreach (Tempera t in paletas._temperas)
            {
                respuesta = !(Object.Equals(t,null) && temperas==t);
            }

            return respuesta;
        }

        public static Paleta operator +(Paleta paletas,Tempera temperas)
        {

        }

        private int obtenerIndice()
        {

        }
    }
}
