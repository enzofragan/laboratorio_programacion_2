using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_14
{
    class ErrorParserException : Exception
    {
      public ErrorParserException(string message) : base("El string no podra ser convertido" + message)
      {

      }
    }
}
