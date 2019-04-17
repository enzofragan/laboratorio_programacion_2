using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
  class lavadero
  {
    private List<vehiculo> _vehiculos;
    private float _precioAuto;
    private float _precioMoto;
    private float _precioCamion;

    //private string Lavadero;

    public string MiLavadero
    {
      get {
        string Lavadero;

        foreach (vehiculo v in this._vehiculos)
        {
          //Lavadero += 
        }

        return Lavadero;
      }
    }


    private lavadero()
    {
      this._vehiculos = new List<vehiculo>();
    }

    public lavadero(float auto,float moto,float camion) : this()
    {
      this._precioAuto = auto;
      this._precioMoto = moto;
      this._precioCamion = camion;
    }
  }
}
