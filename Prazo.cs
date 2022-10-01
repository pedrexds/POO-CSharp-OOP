using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_CSharp_OOP
{
    public class Prazo : Pagamento
    {
        private int qtdParcelas;
        private float valorParcelas;

        public Prazo(float valor, string dataPgto, int qtdParcelas):base(valor, dataPgto)
        {
            this.valorParcelas = valor/qtdParcelas;
            this.qtdParcelas = qtdParcelas;
        }

        public override bool pagar(float valor)
        {
            try
            {
                if(this.valorParcelas > valor)
                {
                    throw new Exception("Valor pago inferior ao valor da parcela.");
                }
                if(this.qtdParcelas == 0)
                {
                    throw new Exception("Dívida quitada, devolvendo o valor");
                }
                
                this.qtdParcelas--;

                if(this.qtdParcelas == 0)
                {
                    Console.WriteLine("Pedido pago, obrigado por comprar em nossa loja!");
                    this.pago = true;
                }
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}