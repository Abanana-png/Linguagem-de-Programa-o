using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Personagem 
  {
    public string Nome; 
    public int Moeda;
    public List<Item> Inventario;

    public Personagem (string nome)
    {
      this.Nome = nome;
      this.Florim = 100;
      this.Inventario = new List<Item>();
    }

    public void ImprimirPersonagem()
    {
      Console.WriteLine("Nome:\t\t{0}", this.Nome);
      Console.WriteLine("Moedas:\t\t{0}", this.Moeda);
      Console.Write("Inventário:\t{");
      foreach (var item in Inventario)
      {
        Console.Write("{0}", item.Nome);
      }
      Console.Write("}\r\n");
    }

    public void ComprarItem(string Comprar,List<Item> Catalogo)
    {
      foreach(var a in Catalogo){
        if (Comprar == a.Nome){
         if (this.Moeda >= a.Moeda){
           this.Moeda = this.Moeda - a.Moeda; 
           this.Inventario.Add(a);
         } 
         else {
           Console.WriteLine("Vai ter que lavar a louça pra pagar.");
         }
        }
      }


      
      
      
    }
    public string Comprar(){
      string Comprar;
      Console.WriteLine("Entre com o item desejado.");
      Comprar = Console.ReadLine();
      return Comprar;


    }


  }