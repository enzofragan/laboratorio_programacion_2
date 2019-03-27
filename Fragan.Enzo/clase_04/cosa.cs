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

    public cosa(int entero)
    {
      this.establecerValorI(entero);
      this.cadena = "sin valor";
      this.fecha = DateTime.Now;
    }

    public cosa(int entero, DateTime fecha)
    {
      this.establecerValorI(entero);
      this.cadena = "sin valor";
      this.establecerValorD(fecha);
    }

    public cosa(int entero, DateTime fecha,string cadena)
    {
      this.establecerValorI(entero);
      this.establecerValorS(cadena);
      this.establecerValorD(fecha);
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
      return this.entero.ToString()+"-"+cadena+"-"+this.fecha.ToShortDateString();
    }

    public static string mostrar(cosa cosas)
    {
      return cosas.mostrar();
    }
  }
}
