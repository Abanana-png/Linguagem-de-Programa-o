using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class MainClass {
  public static void Main (string[] args) 
  {
    Loja Cesta = new Loja();
   
    Personagem Cliente = new Personagem(nome:"Cliente");





    Item espada = new Item(nome:"Espada", descricao:"Afiada",moeda: 90);
    Cesta.Catalogo.Add(espada);

    Item borracha = new Item(nome:"Borracha", descricao:"Afiada",moeda: 10);
    Cesta.Catalogo.Add(borracha);

    Item pizza = new Item(nome:"Pizza", descricao:"Afiada",moeda: 2);
    Cesta.Catalogo.Add(pizza);

    Item cachorro = new Item(nome:"Cachorro", descricao:"Afiada",moeda: 90);
    Cesta.Catalogo.Add(cachorro);



    Cesta.ImpCat();
    string Escolha;

    do{
      


    



     

     Cliente.ComprarItem(Cliente.Comprar(), Cesta.Catalogo);
     Cliente.ImprimirPersonagem();
     Console.WriteLine("Digite 1 para CONTINUAR ou 444 para FECHAR");
     Escolha = Console.ReadLine();
     Cesta.ImpCat();
    }
    while(Escolha == "1");
    if(Escolha != "1")
    {
      Console.WriteLine("\r\nOkay, " + Cliente.Nome + "!" + " Feche a porta ao sair e volte sempre!");
    }
    


     
      
  }
}