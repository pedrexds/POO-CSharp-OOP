using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_CSharp_OOP
{
    public abstract class Pagamento
    {
        protected float valor;
        protected string dataPgto;
        protected bool pago;

        public string getDataPgto()
        {
            return this.dataPgto;
        }

        public float getValor()
        {
            return this.valor;
        }

        public Pagamento(float valor, string dataPgto)
        {
            this.dataPgto = dataPgto;
            this.valor = valor;
            this.pago = false;
        }

        public abstract bool pagar(float valor);
    }
}