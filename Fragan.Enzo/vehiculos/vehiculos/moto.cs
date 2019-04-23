using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculos
{
  public class Moto : vehiculo
  {
    protected float _cilindrada;

    public Moto(string patente, sbyte ruedas, EMarca marca,float cilindrada) : base(patente,ruedas,marca)
    {
      this._cilindrada = cilindrada;
    }

    //public string mostrarMoto()
    //{
    //  return mostrarVehiculo() + "\ncilindrada: " + this._cilindrada;
    //}
    public override string ToString()
    {
      return base.ToString() + " " + this._cilindrada;
    }
  }
}
