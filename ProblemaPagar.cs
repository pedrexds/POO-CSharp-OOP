using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_CSharp_OOP
{
    public class ProblemaPagar : SystemException
    {
        public ProblemaPagar(string msg):base(msg)
        {
            Console.WriteLine(msg);
        }

        public Pagamento mudarPgto(Pagamento obj)
        {
            Console.WriteLine("Mude a forma de pagamento.");
            Console.WriteLine("Digite 1: À vista\nDigite 2: A prazo");

            int opt = Convert.ToInt32(Console.ReadLine());
            switch(opt)
            {
                case 1: if(typeof(Vista).IsInstanceOfType(obj))
                        {
                            throw new NullReferenceException("Objeto nulo, mesma opção de pagamento escolhida: À vista");
                        }
                        return new Vista(obj.getValor(), obj .getDataPgto());

                case 2: if(typeof(Prazo).IsInstanceOfType(obj))
                        {
                            throw new NullReferenceException("Objeto nulo, mesma opção de pagamento escolhida: A prazo");
                        }
                        Console.WriteLine("Digite a quantidade de parcelas: ");
                        int qtdParcelas = Convert.ToInt32(Console.ReadLine());
                        return new Prazo(obj.getValor(), obj.getDataPgto(), qtdParcelas);
                        
                default:throw new NullReferenceException("Objeto nulo / Opção inválida.");
            }
        }
    }
}