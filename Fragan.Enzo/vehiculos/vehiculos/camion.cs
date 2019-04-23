using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
  public class Camion : vehiculo
  {
    protected float _tara;

    public Camion(string patente, sbyte ruedas, EMarca marca,float tara) : base(patente,ruedas,marca)
    {
      this._tara = tara;
    }

    //public string mostrarCamion()
    //{
    //  return mostrarVehiculo() + "tara: " + this._tara;
    //}

    public override string ToString()
    {
      return base.ToString()+" "+this._tara;
    }
  }
}
