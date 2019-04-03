using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase5.entidades
{
    public class Tinta
    {
    private ConsoleColor color;
    private ETipoTinta tipoTinta;

    public Tinta() : this(ConsoleColor.Black, ETipoTinta.comun)
    {
      
    }

    public Tinta(ConsoleColor color) : this(color,ETipoTinta.comun)
    {
      this.color = color;
    }

    public Tinta(ConsoleColor color, ETipoTinta eTipo)
    {
      this.color = color;
      this.tipoTinta = eTipo;
    }

    private string mostrar()
    {
      return "color: " + this.color.ToString() + "\ntipotinta " + this.tipoTinta.ToString();
    }

    public static string mostrar(Tinta tinta)
    {
      return tinta.mostrar();
    }

    public static bool operator ==(Tinta t1,Tinta t2)
    {
      bool respuesta = false;

      respuesta = ((t1.color == t2.color) && (t1.tipoTinta == t2.tipoTinta));

      return respuesta;
    }

    public static bool operator !=(Tinta t1,Tinta t2)
    {
      return !(t1 == t2);
    }
  }
}
