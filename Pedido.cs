using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_CSharp_OOP
{
    public class Pedido
    {
        private Cliente cli;
        private ListaCanetas produtos;
        private string data;
        private float valorTotal;
        private string valorTxt;
        private Pagamento pgto;

        public Pedido(Cliente cli, string data, Pagamento pgto)
        {
            this.cli = cli;
            this.data = data;
            this.valorTotal = 0f;
            this.valorTxt = " ";
            this.pgto = pgto;
            this.produtos = new ListaCanetas();
        }

        public void adicionarProduto(Caneta caneta)
        {
            //Mal implementado no exemplo
        }

        public void fecharPedido(int formaPgto, string dataPgto)
        {
            if(formaPgto == 1)
            {
                this.pgto = new Vista(this.valorTotal, dataPgto);
            }
            else if(formaPgto == 2)
            {
                Console.WriteLine("Digite a quantidade de parcelas: ");
                int qtdParcelas = Convert.ToInt32(Console.ReadLine());
                this.pgto = new Prazo(this.valorTotal, dataPgto, qtdParcelas);
            }
        }

        public void pagarPedido(float valor)
        {
            try
            {
                this.pgto.pagar(valor);
            }
            catch(ProblemaPagar pp)
            {
                Console.Write("Digite um novo valor a ser pago: ");
                this.valorTotal = float.Parse(Console.ReadLine());

                if(this.pgto.getValor() < valor)
                {
                    Console.WriteLine("Não foi possível realizar o pagamento, valor oferecido menor que a dívida.");

                    try
                    {
                        this.pgto = pp.mudarPgto(this.pgto);
                    }
                    catch(NullReferenceException ne)
                    {
                        Console.WriteLine("Pagamento não alterado.");
                        Console.WriteLine(ne.Message);
                    }
                }
            }
        }
    }
}