namespace POO_CSharp_OOP
{
    public class Vista : Pagamento
    {
        public Vista(float valor, string dataPgto):base(valor, dataPgto)
        {
            this.valor = valor;
            this.dataPgto = dataPgto;
        }

        public override bool pagar(float valor)
        {
            if(this.valor < valor)
            {
                throw new ProblemaPagar("O valor que deseja pagar é menor que a dívida.\nValor da dívida: R$" + this.valor);
            }
            this.pago = true;
            return true;
        }
    }
}