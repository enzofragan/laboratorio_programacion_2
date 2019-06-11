using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entdades
{
    public class accesoDatos
    {
        private SqlConnection _coneccion;
        private SqlCommand _comando;

        public accesoDatos(string coneccion)
        {
            coneccion = Properties.Settings.Default.coneccion_db;
            _coneccion = new SqlConnection(coneccion);
        }

        public List<Persona> traerDatos()
        {
            List<Persona> lista = new List<Persona>();
            SqlDataReader lector;
            this._comando = new SqlCommand();

            try
            {
                this._coneccion.Open();
                this._comando.Connection = this._coneccion;
                this._comando.CommandType = CommandType.Text;
                this._comando.CommandText = "SELECT * from Padron.dbo.Personas";
                lector = this._comando.ExecuteReader();


                while (lector.Read())
                {
                    lista.Add((Persona)lector[0]);
                }

                this._coneccion.Close();
            }
            catch (Exception e)
            {

                throw e;
            }
            
            return lista;
        }

        public bool agregarPersonas(Persona persona)
        {
            this._comando.Connection = this._coneccion;
            this._comando.CommandType = CommandType.Text;
            this._comando.CommandText = "insert into Padron.dbo.Personas nombre,apellido,edad values(""+persona.nombre+"",""+persona.apellido+"",""persona.edad.ToString()+"")";
        }

    }
}
