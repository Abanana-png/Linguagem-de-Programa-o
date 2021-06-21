using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Retangulo : Figura 
{
    private double _altura; // atributo
    private double _largura; // atributo
    
    public double Altura // propriedade
    {
        // leitura do atributo correspondente
        get
        {
            return this._altura;
        }
        
        // escrita do atributo correspondente
        set
        {
            if (value <= 0)
            {
                Console.Write("Altura inválida\t");
            }
            else
            {
                this._altura = value;
                this.AtualizarArea();
                this.AtualizarPerimetro();
            }
        }
    }
    public double Largura // propriedade
    {
        // leitura do atributo correspondente
        get
        {
            return this._largura;
        }
        
        // escrita do atributo correspondente
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Inválida");
            }
            else
            {
                this._largura = value;
                this.AtualizarArea();
                this.AtualizarPerimetro();
            }
        }
    }
    public Retangulo(double altura, double largura)
    {
        // escrita utilizando método set da propriedade
        this.Altura = altura;
        this.Largura = largura;
    }
    private void AtualizarArea()
    {
        this._area = this._largura * this._altura;
    }
    private void AtualizarPerimetro()
    {
        this._perimetro = 2 *(this._largura + this._altura);
    }
}