using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;

namespace PersonaEx
{
  public class PersonaExt : PersonaExterna
  {
    public string Nombre
    {
      get
      {
        return this._nombre;
      }
      set
      {
        this._nombre = value;
      }
    }

    public string Apellido
    {
      get
      {
        return this._apellido;
      }
      set
      {
        this._apellido = value;
      }
    }

    public int Edad
    {
      get
      {
        return this._edad;
      }
      set
      {
        this._edad = value;
      }
    }

    public ESexo Sexo
    {
      get
      {
        return this._sexo;
      }
      set
      {
        this._sexo = value;
      }
    }

    public PersonaExt(string nomre,string apelido,int edad, ESexo sexo) : base(nomre,apelido,edad,sexo)
    {
      this.Nombre = nomre;
      this.Apellido = apelido;
      this.Edad = edad;
      this.Sexo = sexo;
    }
  }
}
