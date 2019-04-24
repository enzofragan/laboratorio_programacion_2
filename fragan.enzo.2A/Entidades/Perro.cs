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

        public override bool Equals(object obj)
        {
            bool respuesta;

            if(obj is Perro)
            { 
                respuesta =(Perro)obj == this;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }

        public static explicit operator int(Perro Perro1)
        {
            return Perro1.edad;
        }

        protected override string Ficha()
        {
            string Informacion = "";
            if(this.esAlfa == true)
            {
                Informacion = "alfa de la manada";
            }

            return base.DatosCompletos() +","+Informacion+" edad "+this.edad;
        }

        public static bool operator ==(Perro Perro1, Perro Perro2)
        {
            bool respuesta;

            if(Perro1.Nombre == Perro2.Nombre && Perro1.Raza == Perro2.Raza && Perro1.edad==Perro2.edad)
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }

            return respuesta;
        }

        public static bool operator !=(Perro Perro1, Perro Perro2)
        {
            return !(Perro1 == Perro2);
        }

        public Perro(string Nombre,string Raza) : base(Nombre,Raza)
        {
            this.edad = 0;
            this.esAlfa = false;
        }

        public Perro(string Nombre, string Raza,int edad,bool esAlfa) : this(Nombre,Raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }

        public override string ToString()
        {
            return this.Ficha();
        }
    }
}
