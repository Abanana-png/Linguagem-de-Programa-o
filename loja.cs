using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Loja{
public List <Item> Catalogo = new List<Item> ();
public void Menu (Item Adc){
  this.Catalogo.Add(Adc);
}
public void ImpCat(){
  foreach ( var Adc in Catalogo){
    Adc.ImprimirItem(); 
  }
}




}