using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase5.entidades
{
  public class Pluma
  {
    private string _marca;
    private Tinta _tinta;
    private int _cantidad;

    public Pluma() : this("sin marca", null,0)
    {

    }

    public Pluma(string marca) : this(marca, null, 0)
    {
      this._marca = marca;
    }

    public Pluma(string marca,Tinta tipo) : this(marca, tipo, 0)
    {
      this._marca = marca;
      this._tinta = tipo;
    }

    public Pluma(string marca, Tinta eTipo,int cantidad)
    {
      this._marca = marca;
      this._tinta = eTipo;
      this._cantidad = cantidad;
    }

    private string mostrar()
    {
      return "marca: " + this._marca + "\ntinta: " + Tinta.mostrar(this._tinta)+ "\ncantidad: "+this._cantidad.ToString();
    }

    public static bool operator ==(Pluma t1, Tinta t2)
    {
      bool respuesta = false;

      respuesta = (t1._tinta==t2);

      return respuesta;
    }

    public static bool operator !=(Pluma t1, Tinta t2)
    {
      return !(t1._tinta == t2);
    }
  }
}
