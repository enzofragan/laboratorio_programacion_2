using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
        private string _nombre;
        private string _raza;

        public string Nombre
        {
            get { return _nombre; }
        }

        public string Raza
        {
            get { return _raza; }
        }

        protected virtual string DatosCompletos()
        {
            return this.Nombre + " " + this.Raza;
        }

        protected abstract string Ficha();

        public Mascota(string Nombre, string Raza)
        {
            this._nombre = Nombre;
            this._raza = Raza;
        }
    }
}
