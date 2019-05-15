using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
  public class lavadero
  {
    private List<vehiculo> _vehiculos;
    private Double _precioAuto;
    private Double _precioMoto;
    private Double _precioCamion;

    //private string Lavadero;

    public string MiLavadero
    {
      get {
        string Lavadero = "";

        foreach (vehiculo v in this._vehiculos)
        {
          Lavadero = v.ToString();
        }

        return Lavadero;
      }
    }


    private lavadero()
    {
      this._vehiculos = new List<vehiculo>();
    }

    public lavadero(Double auto, Double moto, Double camion) : this()
    {
      this._precioAuto = auto;
      this._precioMoto = moto;
      this._precioCamion = camion;
    }

    public static bool operator ==(lavadero lavadero, vehiculo vehiculo)
    {
      bool retorno = false;
      foreach (vehiculo vehiculos in lavadero._vehiculos)
      {
        if (vehiculo == vehiculos)
        {
          retorno = true;
          break;
        }
      }
      return retorno;
    }

    public static bool operator !=(lavadero lavadero, vehiculo vehiculo)
    {
      return !(lavadero == vehiculo);
    }

    public static lavadero operator +(lavadero lavadero, vehiculo vehiculo)
    {
      if (lavadero != vehiculo)
      {
        lavadero._vehiculos.Add(vehiculo);
      }
      return lavadero;
    }

    public static lavadero operator -(lavadero lavadero, vehiculo vehiculo)
    {
      int indice = (vehiculo == lavadero);
      if (indice != -1)
      {
        lavadero._vehiculos.RemoveAt(indice);
      }
      return lavadero;
    }

    public static int operator ==(vehiculo vehiculo, lavadero lavadero)
    {
      int retorno = -1;
      int i;
      for (i = 0; i < lavadero._vehiculos.Count; i++)
      {
        if (vehiculo == lavadero._vehiculos[i])
        {
          retorno = i;
        }
      }
      return retorno;
    }

    public static int operator !=(vehiculo vehiculo, lavadero lavadero)
    {
      return vehiculo == lavadero;
    }
  }
}
