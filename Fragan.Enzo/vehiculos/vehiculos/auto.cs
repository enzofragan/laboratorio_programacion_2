using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
  public class Auto : vehiculo
  {
    protected int _cantidadAsientos;

    public Auto(string patente, sbyte ruedas, EMarca marca,int asientos) : base(patente,ruedas,marca)
    {
      this._cantidadAsientos = asientos;
    }

    // public string mostrarAuto()
    // {
    //   return mostrarVehiculo() + "cantidad de asientos: " + this._cantidadAsientos;
    // }

    public override string ToString()
    {
      return base.ToString() + " " + this._cantidadAsientos;
    }
  }
}
