using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_04
{
  public class cosa
  {
    public int entero;
    public string cadena;
    public DateTime fecha;

    public cosa()
    {
      this.entero = 10;
      this.cadena = "sin valor";
      this.fecha = DateTime.Now;
    }

    public cosa(int entero) : this()
    {
      this.establecerValorI(entero);
    }

    public cosa(int entero, DateTime fecha) : this(entero)
    {
      this.establecerValorD(fecha);
    }

    public cosa(int entero, DateTime fecha,string cadena) : this(entero,fecha)
    {
      this.establecerValorS(cadena);
    }

    public void establecerValorI(int entero)
    {
      this.entero = entero;
    }

    public void establecerValorS(string cadena)
    {
      this.cadena = cadena;
    }

    public void establecerValorD(DateTime fecha)
    {
      this.fecha = fecha;
    }

    public string mostrar()
    {
      return this.entero.ToString()+"-"+cadena+"-"+this.fecha.ToString();
    }

    public static string mostrar(cosa cosas)
    {
      return cosas.mostrar();
    }
  }
}
