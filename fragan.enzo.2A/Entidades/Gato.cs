using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {
        public override bool Equals(object obj)
        {
            bool respuesta;

            if (obj is Gato)
            {
                respuesta = (Gato)obj == this;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }

        protected override string Ficha()
        {
            return this.Nombre + " " + this.Raza;
        }

        public Gato(string Nombre,string Raza) : base(Nombre,Raza)
        {

        }

        public static bool operator ==(Gato Gato1,Gato Gato2)
        {
            bool respuesta;

            if (Gato1.Nombre == Gato2.Nombre && Gato1.Raza == Gato2.Raza)
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }

        public static bool operator !=(Gato Gato1,Gato Gato2)
        {
            return !(Gato1 == Gato2);
        }

        public override string ToString()
        {
            return base.DatosCompletos();
        }
    }
}
