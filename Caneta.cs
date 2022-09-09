using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_CSharp_OOP
{
    public class Caneta
    {
        //Atributos
        string modelo;
        string marca;
        string cor;
        float capacidadeTotal;
        float capacidadeAtual;
        float espessura;
        float comprimento;
        bool tampa;
    
        //Método Construtor
        public Caneta(string modelo, string marca, string cor, float capacidadeTotal, float espessura, float comprimento, bool tampa)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.cor = cor;
            this.capacidadeTotal = capacidadeTotal;
            this.capacidadeAtual = capacidadeTotal;
            this.espessura = espessura;
            this.comprimento = comprimento;
            this.tampa = tampa;
        }

        //Método de impressão dos atributos
        public void info()
        {
            Console.WriteLine("Modelo: " + this.modelo +
                "\nMarca: " + this.marca +
                "\nCor: " + this.cor +
                "\nCapacidade Total: " + this.capacidadeTotal +
                "\nCapacidade Atual: " + this.capacidadeAtual +
                "\nEspessura: " + this.espessura +
                "\nComprimento: " + this.comprimento +
                "\nTem tampa?: " + this.tampa);
        }

        //Método de impressão dos atributos
        public string toString()
        {
            return
                "Modelo: " + this.modelo +
                "\nMarca: " + this.marca +
                "\nCor: " + this.cor +
                "\nCapacidade Total: " + this.capacidadeTotal +
                "\nCapacidade Atual: " + this.capacidadeAtual +
                "\nEspessura: " + this.espessura +
                "\nComprimento: " + this.comprimento + 
                "\nTem tampa?: " + this.tampa;
        }
    }
}