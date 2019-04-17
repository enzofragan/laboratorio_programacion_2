using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
  public class vehiculo
  {
    public sbyte _cantidadRuedas;

    private string _patente;

    public string patente
    {
      get { return _patente; }
    }

    private EMarca _Marca;

    public EMarca marca
    {
      get { return _Marca; }
    }

    public vehiculo(string patente,sbyte ruedas, EMarca marca)
    {
      this._cantidadRuedas = ruedas;
      this._Marca = marca;
      this._patente = patente;
    }

    protected string mostrarVehiculo()
    {
      return "patente: " + this.patente + "\nmarca: " + this.marca + "\ncantidad de ruedas: "+ this._cantidadRuedas;
    }

    public static bool operator ==(vehiculo VehiculoUno,vehiculo VehiculoDos)
    {
      bool respuesta = false;

      if(VehiculoUno != null && VehiculoDos != null)
      {
        if(VehiculoUno.patente == VehiculoDos.patente && VehiculoUno.marca == VehiculoDos.marca)
        {
          respuesta = true;
        }
      }

      return respuesta;
    }

    public static bool operator !=(vehiculo VehiculoUno, vehiculo VehiculoDos)
    {
      return !(VehiculoUno == VehiculoDos);
    }
  }
}
