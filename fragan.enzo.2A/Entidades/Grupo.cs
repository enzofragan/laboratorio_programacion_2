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
            set { Tipo = value; }
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

        }

        public Grupo(string Nombre, ETipoManada Tipo) : this(Nombre)
        {

        }

        public static implicit operator string(Grupo Grupo1)
        {

        }

        public static bool operator ==(Grupo Grupo1, Mascota Mascota1)
        {

        }

        public static bool operator !=(Grupo Grupo1, Mascota Mascota1)
        {
            return !(Grupo1 == Mascota1);
        }

        public static Grupo operator +(Grupo Grupo1, Mascota Mascota1)
        {

        }

        public static Grupo operator -(Grupo Grupo1, Mascota Mascota1)
        {

        }
    }
}
