using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace clase_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("ramiro", "gallego");
            Alumno alumno1 = new Alumno();
            Profesor profesor1 = new Profesor();

            persona1.Dni = 3352580;
            persona1.nombre = "ramiro";
            persona1.apellido = "gallego";
            profesor1.Titulo = "tecnico";
            alumno1.Legajo = 123456;

            Console.WriteLine(profesor1.ToString());
            Console.ReadLine();
        }

        static bool SerializadorAlumno(Alumno alumno)
        {
            try
            {
                XmlSerializer xmlserializador = new XmlSerializer(typeof(Alumno));
                StreamWriter serializador = new StreamWriter("clase 18\texto.txt", true);
                xmlserializador.Serialize(serializador, alumno);
                serializador.Close();
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
            
        }

        static Alumno DeserializerAlumno(string direccion)
        {
            XmlSerializer xmlserializador = new XmlSerializer(typeof(Alumno));
            StreamReader lector = new StreamReader(direccion);
            Alumno ret = (Alumno)xmlserializador.Deserialize(lector);
            lector.Close();
            return ret;
        }

    }
}
