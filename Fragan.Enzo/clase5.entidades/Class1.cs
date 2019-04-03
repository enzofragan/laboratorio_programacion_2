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

    public tinta()
    {
      this.color = ConsoleColor.Black;
      this.tipoTinta = ETipoTinta.comun;
    }

    public tinta(ConsoleColor color) : this()
    {
      this.color = color;
    }

    public tinta(ConsoleColor color, ETipoTinta eTipo) : this(color)
    {
      this.tipoTinta = eTipo;
    }

    private string mostrar()
    {
      return "color:" + this.color.ToString() + "\ntipotinta" + this.tipoTinta.ToString();
    }

    public static string mostrar(tinta tinta)
    {
      return "color:" + tinta.color.ToString() + "\ntipotinta" + tinta.tipoTinta.ToString();
    }
  }
}
