using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_CSharp_OOP
{
    public class Endereco
    {
        private string rua;
        private string estado;
        private int num;
        private string cep;

        public Endereco(string rua, string estado, string cep, int num)
        {
            this.rua = rua;
            this.estado = estado;
            this.cep = cep;
            this.num = num;
        }

        public string toString()
        {
            return this.rua + " ; " + this.estado + " ; " + this.num + " ; " + this.cep;
        }
    }
}