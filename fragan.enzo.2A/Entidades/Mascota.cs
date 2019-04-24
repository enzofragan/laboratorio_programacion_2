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
            get { return Nombre; }
        }

        public string Raza
        {
            get { return Raza; }
        }

        protected virtual string DatosCompletos()
        {
            return "Nombre: " + this._nombre + "\nRaza: " + this._raza;
        }

        protected abstract string Ficha();

        public Mascota(string Nombre, string Raza)
        {
            this._nombre = Nombre;
            this._raza = Raza;
        }
    }
}
