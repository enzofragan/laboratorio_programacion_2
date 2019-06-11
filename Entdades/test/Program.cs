using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entdades;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> l;
            accesoDatos dats = new accesoDatos("");
            l = dats.traerDatos();

            foreach(Persona p in l)
            {
                p.ToString();
            }
        }
    }
}
