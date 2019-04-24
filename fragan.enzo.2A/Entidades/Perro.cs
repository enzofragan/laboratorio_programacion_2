using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        public bool Equals(object obj)
        {

        }

        public static explicit operator int(Perro Perro1)
        {

        }

        protected string Ficha()
        {

        }

        public static bool operator ==(Perro Perro1, Perro Perro2)
        {

        }

        public static bool operator !=(Perro Perro1, Perro Perro2)
        {
            return !(Perro1 == Perro2);
        }

        public Perro(string Nombre,string Raza) : base(Nombre,Raza)
        {

        }

        public Perro(string Nombre, string Raza,int edad,bool esAlfa) : this(Nombre,Raza)
        {

        }

        public override string ToString()
        {
            return base.DatosCompletos();
        }
    }
}
