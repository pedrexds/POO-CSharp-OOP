using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_CSharp_OOP
{
    public class Cliente
    {
        private string nome;
        private string cpf;
        private Endereco endereco;

        public Cliente(string nome, string cpf, string rua, string estado, string cep)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = new Endereco(rua, estado, cep);
        }

        public bool igual(string cpf)
        {
            return string.Equals(this.cpf,cpf);
        }
    }
}