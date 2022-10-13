namespace POO_CSharp_OOP
{
    public class Cliente
    {
        private string nome;
        private string cpf;
        private string rg;
        private Endereco endereco;

        public Cliente(string nome, string cpf, string rg, string rua, string estado, string cep, int num)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.rg = rg;
            this.endereco = new Endereco(rua, estado, cep, num);
        }

        public bool igual(string cpf, string rg) //Sobrecarga de função
        {
            return string.Equals(this.cpf, cpf) && string.Equals(this.rg, rg);
        }

        public bool igual(string cpf)//Sobrecarga de função
        {
            return string.Equals(this.cpf, cpf);
        }
    }
}