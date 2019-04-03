using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase5.entidades
{
    public class tinta
    {
    private ConsoleColor color;
    private ETipoTinta tipoTinta;

    public tinta() : this(ConsoleColor.Black, ETipoTinta.comun)
    {
      
    }

    public tinta(ConsoleColor color) : this(color,ETipoTinta.comun)
    {
      this.color = color;
    }

    public tinta(ConsoleColor color, ETipoTinta eTipo)
    {
      this.color = color;
      this.tipoTinta = eTipo;
    }

    private string mostrar()
    {
      return "color: " + this.color.ToString() + "\ntipotinta " + this.tipoTinta.ToString();
    }

    public static string mostrar(tinta tinta)
    {
      return tinta.mostrar();
    }
  }
}
