using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;

        public int Codigo { get { return this._codigo; } }
        public bool EsIndstrial { get { return this._esIndustrial; } }
        public double Precio { get { return this._precio; } }

        public Cocina(int codigo,double precio,bool esindustrial)
        {
            this._codigo = codigo;
            this._esIndustrial = esindustrial;
            this._precio = precio;
        }

        public override bool Equals(object obj)
        {
            bool respuesta = false;

            Cocina Aux = obj as Cocina;

            if (Aux != null)
            {
                if (Aux.Codigo == this.Codigo)
                {
                    respuesta = true;
                }
            }

            return respuesta;
        }

        public static bool operator ==(Cocina a, Cocina b)
        {
            bool respuesta = false;

            if(a._codigo==b._codigo && a._esIndustrial==b._esIndustrial && a._precio==b._precio)
            {
                respuesta = true;
            }

            return respuesta;
        }

        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            string inf = "";

            inf = "\nCodigo: " + this.Codigo + " - " + "Precio: " + this.Precio + " - " + "Es Industrial? " + this.EsIndstrial;

            return inf;
        }
    }
}
