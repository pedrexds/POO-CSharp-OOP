using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_CSharp_OOP
{
    public class MarcaTexto : Caneta
    {
        private int tipoPonta;
        private int tipoTinta;
        
        //base == super do Java -> chama especificamente métodos e atributos da classe pai

        public MarcaTexto(string modelo, string marca, string cor, float capacidadeTotal, float espessura, float comprimento, bool tampa, float valor, int tipoPonta, int tipoTinta):base(modelo, marca, cor, capacidadeTotal, espessura, comprimento, tampa, valor)
        {
            this.tipoPonta = tipoPonta;
            this.tipoTinta = tipoTinta;
        }

        public override void info() //override: sinaliza a sobrescrita de um método herdado
        {
            base.info();
            
            if(this.tipoPonta == 0)
            {
                Console.WriteLine("Tipo da Ponta: Fina");
            }
            else
            {
                Console.WriteLine("Tipo da Ponta: Chata");
            }

            if(this.tipoTinta == 0)
            {
                Console.WriteLine("Tipo da Tinta: Base água.");
            }
            else if(this.tipoTinta == 1)
            {
                Console.WriteLine("Tipo da Tinta: Gel.");
            }
            else
            {
                Console.WriteLine("Tipo da Tinta: Permanente");
            }
        }
    }
}