using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_CSharp_OOP
{
    public abstract class Caneta : Funcionalidades //"Caneta implements Funcionalidades" no Java
    {
        //Atributos
        protected string modelo;
        protected string marca;
        protected string cor;
        protected float capacidadeTotal;
        protected float capacidadeAtual;
        protected float espessura;
        protected float comprimento;
        protected float valor;
        protected string tipoCaneta;
        //private int quantidade;
    
        //Método Construtor
        public Caneta(string modelo, string marca, string cor, float capacidadeTotal, float espessura, float comprimento, float valor)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.cor = cor;
            this.capacidadeTotal = capacidadeTotal;
            this.capacidadeAtual = capacidadeTotal;
            this.espessura = espessura;
            this.comprimento = comprimento;
            this.valor = valor;
            this.tipoCaneta = "Comum";
        }

        public bool igual(string modelo)
        {
            return this.modelo.Equals(modelo);
        }

        public bool compare(Caneta caneta)
        {
            return this.modelo.Equals(caneta.getModelo()) && this.marca.Equals(caneta.getMarca());
        }

        public string getModelo()
        {
            return this.modelo;
        }

        public string getMarca()
        {
            return this.marca;
        }

        public float getCapacidadeTotal()
        {
            return this.capacidadeTotal;
        }

        //Método de impressão dos atributos
        public virtual void info() //virtual: indica que o método pode ser sobrescrito em uma classe filha
        {
            Console.WriteLine("\n***Caneta " + this.tipoCaneta + "***");
            Console.WriteLine("Modelo: " + this.modelo +
                "\nMarca: " + this.marca +
                "\nCor: " + this.cor +
                "\nCapacidade Total: " + this.capacidadeTotal +
                "\nCapacidade Atual: " + this.capacidadeAtual +
                "\nEspessura: " + this.espessura +
                "\nComprimento: " + this.comprimento);
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
                "\nComprimento: " + this.comprimento;
        }

        public abstract bool escrever();
        
        public abstract void apagar();
    }
}