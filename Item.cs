using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Item 
  {
    public string Nome;
    public string Descricao;
    public int Moeda;

    public Item(string nome, string descricao, int moeda)
    {
      this.Nome = nome;
      this.Descricao = descricao;
      this.Moeda = moeda;
    }
    
    public void ImprimirItem()
    {
      Console.WriteLine("Nome:\t\t{0}", this.Nome);
      Console.WriteLine("Descrição:\t{0}", this.Descricao);
      Console.WriteLine("Moedas:\t\t{0}\r\n", this.Moeda);
    }
  }
