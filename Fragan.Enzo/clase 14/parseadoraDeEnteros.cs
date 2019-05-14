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
        throw new Exception ("El string no podrá ser convertido por error de formato",e);
      }
      catch (OverflowException f)
      {  
        throw new Exception ("El string no podrá ser convertido por tamaño del dato",f);
      }

      return numero;
    }

    public static bool TryParse(string cadena, out int entero)
    {
      bool respuesta = false;
      entero = 0;
      if(Parse(cadena) != 0)
      {
        respuesta = true;
      }

      return respuesta;
    }
  }
}
