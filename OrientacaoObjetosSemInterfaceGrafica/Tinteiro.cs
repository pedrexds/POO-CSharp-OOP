namespace POO_CSharp_OOP
{
    public class Tinteiro : Caneta
    {
        public Tinteiro(string modelo, string marca, string cor, float capacidadeTotal, float espessura, float comprimento, float valor):base(modelo, marca, cor, capacidadeTotal, espessura, comprimento, valor)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.cor = cor;
            this.capacidadeTotal = this.capacidadeAtual = capacidadeTotal;
            this.espessura = espessura;
            this.comprimento = comprimento;
            this.valor = valor;
        }

        public override bool escrever()
        {
            if(this.capacidadeAtual > 0)
            {
                Console.WriteLine("Escrita formal.");
                this.capacidadeAtual--;
                return true;
            }
            else
            {
                Console.WriteLine("Caneta vazia.");
                return false;
            }
        }

        public override void apagar()
        {
            throw new NotSupportedException("Tinteiro não apaga.");
        }
    }
}