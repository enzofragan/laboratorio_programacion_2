using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades.Estacionamientos.starter;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void espacioEstacionamiento()
    {
      Estacionamiento estacionamiento = new Estacionamiento(100);
      Estacionamiento estacionamiento2 = new Estacionamiento(0);
      if(estacionamiento.EspacioDisponible != 100)
      {
        Assert.Fail("El espacio es incorrecto",estacionamiento.EspacioDisponible);
      }
      Assert.AreNotEqual(estacionamiento2.EspacioDisponible, 1);
      if(estacionamiento2.EspacioDisponible!=0)
      {
        Assert.Fail("El espacio es incorrecto", estacionamiento2.EspacioDisponible);
      }
    }
    [TestMethod]
    public void TestMethod1()
    {
      Estacionamiento estacionamiento = new Estacionamiento(5);
      Assert.IsNotNull(estacionamiento.Autos);
    }

    [TestMethod]
    public void agregarAutosAEstacionamientos()
    {
      Estacionamiento estacionamiento = new Estacionamiento(2);
      Auto auto1 = new Auto("1G5F5T9G", ConsoleColor.Black);
      Auto auto2 = new Auto("2H1D3Y5E", ConsoleColor.Cyan);
      Auto auto3 = new Auto("9D4H88R5", ConsoleColor.DarkGreen);

      try
      {
        estacionamiento += auto1;
        estacionamiento += auto2;
        estacionamiento += auto3;
        Assert.Fail("el estacionamiento de 2 acepto tres autos");
      }
      catch (Exception error)
      {
        Assert.IsInstanceOfType(error, typeof(EstacionamientoLlenoException));
        throw;
      }
    }

    [TestMethod]
    public void agregarAutoEspacioDisponible()
    {
      Estacionamiento estacionamiento = new Estacionamiento(2);
      Auto auto1 = new Auto("1G5F5T9G", ConsoleColor.Black);
      Auto auto2 = new Auto("2H1D3Y5E", ConsoleColor.Cyan);

      estacionamiento += auto1;
      Assert.AreEqual(estacionamiento.EspacioDisponible, 1);
      estacionamiento += auto2;
      Assert.AreEqual(estacionamiento.EspacioDisponible, 0);
    }
  }
}
