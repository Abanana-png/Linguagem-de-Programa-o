using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Interador 
{
  public List<Figura> Figuras = new List<Figura>();

  public void Listafig(Figura figura)
  {
    this.Figuras.Add(figura);
  }
  
  public void ImprimirFiguras()
  {
    foreach (var figura in Figuras)
    {
      Console.WriteLine("\n" + figura);
      figura.ImprimirFig();
    }
  }
}