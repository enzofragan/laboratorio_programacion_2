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
            this._temperas = new Tempera[this._cantidadMaxima];
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
              if (!(object.Equals(t, null)) && temperas == t)
              {
                respuesta = true;
              }
            }

            return respuesta;
        }

        public static bool operator !=(Paleta paletas,Tempera temperas)
        {
          return !(paletas == temperas);
        }

        public static Paleta operator +(Paleta paletas,Tempera temperas)
        {
          int index = paletas.ObtenerIndice(temperas);

          if(index != -1)
          {
            paletas._temperas[index] += temperas;
          }
          else
          {
            index = paletas.obtenerIndice();
            if(index!=-1)
            {
              paletas._temperas[index] = temperas;
            }
          }

          return paletas;
        }

        private int obtenerIndice()
        {
          int i;
          int indice = -1;
          for (i = 0; i < this._cantidadMaxima; i++)
          {
            if (!Object.Equals(this._temperas[i],null))
            {
              indice = i;
              break;
            }
          }
          return indice;
        }

        private int ObtenerIndice(Tempera t)
        {
          int indice = 0;
          int i;
          for (i = 0; i < this._cantidadMaxima; i++)
          {
            if (!(Object.Equals(this._temperas[indice], null)) && this._temperas[i] == t)
            {
              indice = i;
            }
          }
          return indice;
        }

        public static Paleta operator -(Paleta paletas, Tempera temperas)
        {
          int indice;
          sbyte aux1;
          sbyte aux2;

          indice = paletas.ObtenerIndice(temperas);

          if(indice != -1)
          {
            aux1 = (sbyte)temperas;
            paletas._temperas[indice] += (sbyte)(aux1 * (-1));
            aux2 = (sbyte)paletas._temperas[indice];
            if(aux2<=0)
            {
              paletas._temperas[indice] = null;
            }
          }

          return paletas;
        }

        public Tempera this[int indice]
        {
          get
          {
            if(indice >= 0 && !(object.Equals(this._temperas[indice],null))&& indice<this._cantidadMaxima)
            {
              return this._temperas[indice];
            }
            else
            {
              return null;
            }
          }
          set
          {
            if(indice>=0 && indice <this._cantidadMaxima)
            {
              this._temperas[indice] = value;
            }
          }
        }
    }
}
