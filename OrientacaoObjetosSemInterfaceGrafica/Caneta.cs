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
        public Caneta(string modelo, string marca, string cor, float capacidadeTotal, float espessura, float comprimento, float valor) //Construtor
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

        public string getModelo() //getter
        {
            return this.modelo;
        }

        public string getMarca() //getter
        {
            return this.marca;
        }

        public float getCapacidadeTotal() //getter
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

        public static bool operator > (Caneta a, Caneta b) //Sobrecarga de operador
        {
            if(a.comprimento > b.comprimento)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator < (Caneta a, Caneta b)//Sobrecarga de operador
        {                                                 //Obrigatória para complementar a anterior
            if(a.comprimento < b.comprimento)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public abstract bool escrever();
        
        public abstract void apagar();
    }
}