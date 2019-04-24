using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {
        public bool Equals(object obj)
        {

        }

        protected string Ficha()
        {

        }

        public Gato(string Nombre,string Raza) : base(Nombre,Raza)
        {

        }

        public static bool operator ==(Gato Gato1,Gato Gato2)
        {

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
