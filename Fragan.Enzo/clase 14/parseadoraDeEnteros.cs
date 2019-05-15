using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_14
{
  public static class parseadoraDeEnteros
  {
    public static int Parse(string cadena)
    {
      int numero;

      try
      {
        numero = int.Parse(cadena);
      }
      catch (FormatException e)
      {
        throw new ErrorParserException(e.Message + "por error de formato");
      }
      catch (OverflowException f)
      {
        throw new ErrorParserException(f.Message + "por tamaño del dato");
      }

      return numero;
    }

    public static bool TryParse(string cadena, out int entero)
    {
      bool respuesta = false;
      entero = 0;
      try
      {
        entero = Parse(cadena);
        if(entero!=0)
        {
          respuesta = true;
        }
      }
      catch (Exception)
      {
        respuesta = false;
      }

      return respuesta;
    }
  }
}
