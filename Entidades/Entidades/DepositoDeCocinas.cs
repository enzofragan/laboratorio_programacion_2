using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        public bool Agregar(Cocina a)
        {
            bool respuesta = false;

            if (this._lista.Count < this._capacidadMaxima)
            {
                this._lista.Add(a);
                respuesta = true;
            }

            return respuesta;
        }

        public DepositoDeCocinas(int capacidad)
        {
            this._lista = new List<Cocina>();
            this._capacidadMaxima = capacidad;
        }

        private int GetIndice(Cocina a)
        {
            int aux = -1;
            int i;

            for (i = 0; i < this._lista.Count; i++)
            {
                if (a == this._lista[i])
                {
                    aux = i;
                }
            }

            return aux;
        }

        public static bool operator +(DepositoDeCocinas b, Cocina a)
        {
            bool respuesta = false;

            if (b.Agregar(a) == true)
            {
                respuesta = true;
            }

            return respuesta;
        }

        public static bool operator -(DepositoDeCocinas b, Cocina a)
        {
            bool respuesta = false;

            if (b.Remover(a) == true)
            {
                respuesta = true;
            }

            return respuesta;
        }

        public bool Remover(Cocina a)
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

            foreach (Cocina a in this._lista)
            {
                ret += a.ToString();
            }
            ret += "\n";
            inf += ret;

            return inf;
        }
    }
}
