using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Figura
{
  protected double _area; // atributo
  protected double _perimetro; // atributo

  public double Area // propriedade
  {
    // leitura do atributo correspondente
    get { return this._area; }
  }

  public double Perimetro // propriedade
  {
    // leitura do atributo correspondente
    get { return this._perimetro; }
  }

  public void ImprimirFig()
  {   
    Console.WriteLine("Area:\t\t{0:0.0}", this._area);
    Console.WriteLine("Perímetro:\t{0:0.0}\n===============================", this._perimetro);
  }
}