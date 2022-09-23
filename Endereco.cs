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

        public Endereco(string rua, string estado, string cep)
        {
            this.rua = rua;
            this.estado = estado;
            this.cep = cep;
        }
    }
}