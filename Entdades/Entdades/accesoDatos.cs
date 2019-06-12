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

        public accesoDatos()
        {
            _coneccion = new SqlConnection(Properties.Settings.Default.coneccion_db);
        }

        public List<Persona> traerDatos()
        {
            List<Persona> lista = new List<Persona>();
            SqlDataReader lector;

            try
            {
                this._comando = new SqlCommand();
                this._comando.Connection = this._coneccion;
                this._comando.CommandType = CommandType.Text;
                this._comando.CommandText = "SELECT * from Padron.dbo.Personas";

                this._coneccion.Open();
  
                lector = this._comando.ExecuteReader();


                while (lector.Read())
                {
                    Persona p = new Persona((int)lector["id"], lector["nombre"].ToString(), lector["apellido"].ToString(), (int)lector["edad"]);
                    lista.Add(p);
                }

                this._coneccion.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
            return lista;
        }

        public bool agregarPersonas(Persona persona)
        {
             bool respuesta = false;

            try
            {
              this._comando = new SqlCommand();
              this._comando.Connection = this._coneccion;
              this._comando.CommandType = CommandType.Text;
              this._comando.CommandText = "insert into Padron.dbo.Personas (nombre,apellido,edad) values('"+persona.nombre+"','"+persona.apellido+"',"+persona.edad.ToString()+")";
              this._coneccion.Open();

              if(this._comando.ExecuteNonQuery()>0)
              {
                respuesta = true;
              }

              this._coneccion.Close();
            }
            catch (Exception e)
            {
              Console.WriteLine(e.Message);
            }

          return respuesta;

        }

        public DataTable traerTablaPersonas()
        {
           DataTable tabla = new DataTable("Personas");
           SqlDataReader lector;
            try
            {
              this._comando = new SqlCommand();
              this._comando.Connection = this._coneccion;
              this._comando.CommandType = CommandType.Text;
              this._comando.CommandText = "SELECT * from Padron.dbo.Personas";

              this._coneccion.Open();

              lector = this._comando.ExecuteReader();

              tabla.Load(lector);

              this._coneccion.Close();
              
            }
            catch (Exception e)
            {

              throw e;
            }
          return tabla;
        }

    }
}
