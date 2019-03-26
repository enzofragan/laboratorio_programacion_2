using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boligrafos
{
  class Boligrafo
  {
    const short cantidadTintaMaxima = 100;
    private ConsoleColor color;
    private short tinta;

    public Boligrafo(short tinta, ConsoleColor color)
    {
      this.color = color;//
      this.tinta = tinta;//
    }

    public ConsoleColor GetColor()
    {
      return this.color;//
    }

    public short GetTinta()
    {
      return this.tinta;//
    }

    //public bool Pintar(int gasto, out string dibujo)
    //{
      
    //}

    public void recargar()
    {
      SetTinta(cantidadTintaMaxima);//
    }

    private void SetTinta(short tinta)
    {
      this.tinta = tinta;//
    }
  }
}
