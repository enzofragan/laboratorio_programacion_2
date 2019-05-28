using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public bool Agregar(T a)
        {
            bool respuesta = false;

            if (this._lista.Count < this._capacidadMaxima)
            {
                this._lista.Add(a);
                respuesta = true;
            }

            return respuesta;
        }

        public Deposito(int capacidad)
        {
            this._lista = new List<T>();
            this._capacidadMaxima = capacidad;
        }

        private int GetIndice(T a)
        {
            int aux = -1;
            int i;

            for (i = 0; i < this._lista.Count; i++)
            {
                if (this._lista[i].Equals(a))
                {
                    aux = i;
                }
            }

            return aux;
        }

        public static bool operator +(Deposito<T> b, T a)
        {
            bool respuesta = false;

            if (b.Agregar(a) == true)
            {
                respuesta = true;
            }

            return respuesta;
        }

        public static bool operator -(Deposito<T> b, T a)
        {
            bool respuesta = false;

            if (b.Remover(a) == true)
            {
                respuesta = true;
            }

            return respuesta;
        }

        public bool Remover(T a)
        {
            bool respuesta = false;

            int index = -1;

            index = this.GetIndice(a);

            if (index != -1)
            {
                this._lista.RemoveAt(index);
            }

            return respuesta;
        }

        public override string ToString()
        {
            string inf = "Capacidad Maxima: " + this._capacidadMaxima.ToString() + "\n";

            string ret = "Listado de Cocinas:";

            foreach (T a in this._lista)
            {
                ret += a.ToString();
            }
            ret += "\n";
            inf += ret;

            return inf;
        }
    }
}
