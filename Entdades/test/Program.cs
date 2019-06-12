using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entdades;

namespace test
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Persona> l;
      accesoDatos dats = new accesoDatos();
      l = dats.traerDatos();

      foreach(Persona p in l)
      {
        Console.WriteLine(p.ToString());
      }

      Console.WriteLine("lista cargada");

      Console.ReadLine();

      /*Persona persona = new Persona(6, "enzo", "fragan", 20);

      if(dats.agregarPersonas(persona)==true)
      {
        l = dats.traerDatos();

        foreach (Persona p in l)
        {
          Console.WriteLine(p.ToString());
        }

        Console.WriteLine("\nse a agregado exitosamente");
      }*/

      DataTable tabla = new DataTable();

      tabla = dats.traerTablaPersonas();

      foreach(DataRow t in tabla.Rows)
      {
        Console.WriteLine(t["id"].ToString(),t["nombre"],t["apellido"],t["edad"].ToString());
      }

      tabla.WriteXmlSchema("Personas_esquema.xml");

      tabla.WriteXml("Personas_datos.xml");

      tabla.ReadXmlSchema("Personas_esquema.xml");

      tabla.ReadXml("Personas_datos.xml");

      Console.ReadLine();
    }
  }
}
