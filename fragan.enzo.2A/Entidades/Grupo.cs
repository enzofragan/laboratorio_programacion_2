using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        private List<Mascota> _manada;
        private string _nombre;
        private static ETipoManada _tipo;

        public ETipoManada Tipo
        {
            set { _tipo = value; }
        }

        static Grupo()
        {
            Grupo._tipo = ETipoManada.Unica;
        }

        private Grupo()
        {
            this._manada = new List<Mascota>();
        }

        public Grupo(string Nombre) : this()
        {
            this._nombre = Nombre;
        }

        public Grupo(string Nombre, ETipoManada Tipos) : this(Nombre)
        {
            this.Tipo = Tipos;
        }

        public static implicit operator string(Grupo Grupo1)
        {
            string info = "grupo: " + Grupo1._nombre + " tipo: " +Grupo._tipo+ "\n integrantes <"+Grupo1._manada.Count.ToString()+">";

            string ret = "\n ";
            foreach(Mascota G in Grupo1._manada)
            {
                ret += G.ToString();
                ret += "\n";
            }

            info += ret;

            return info;
        }

        public static bool operator ==(Grupo Grupo1, Mascota Mascota1)
        {
            bool respuesta = false;
            foreach(Mascota G in Grupo1._manada)
            {
                if(Mascota1.Nombre==G.Nombre && Mascota1.Raza==G.Raza)
                {
                    respuesta = true;
                    break;
                }
            }

            return respuesta;
        }

        public static bool operator !=(Grupo Grupo1, Mascota Mascota1)
        {
            return !(Grupo1 == Mascota1);
        }

        public static Grupo operator +(Grupo Grupo1, Mascota Mascota1)
        {
            if(Grupo1!=Mascota1)
            {
                Grupo1._manada.Add(Mascota1);
            }

            return Grupo1;
        }

        public static Grupo operator -(Grupo Grupo1, Mascota Mascota1)
        {
            if(Grupo1==Mascota1)
            {
                Grupo1._manada.Remove(Mascota1);
            }
            else
            {
                Console.Write("la mascota no se encuentra en la lista\n");
            }

            return Grupo1;
        }
    }
}
