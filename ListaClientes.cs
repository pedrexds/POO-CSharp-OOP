using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_CSharp_OOP
{
    public class ListaClientes
    {
        private ArrayList lista;

        public ListaClientes()
        {
            this.lista = new ArrayList();
        }
        
        private Cliente buscar(string cpf)
        {
            foreach(Cliente cli in this.lista)
            {
                if(cli.igual(cpf))
                {
                    return cli;
                }
            }
            throw new Exception("Cliente não encontrado.");
        }
        
        public Cliente insereCliente(string nome, string cpf, string rua, string estado, int num, string cep)
        {
            Cliente cli = this.buscar(cpf);

            if(cli != null)
            {
                return cli;
            }
            else
            {
                cli = new Cliente(nome, cpf, rua, estado, cep, num);
                this.lista.Add(cli);
                return cli;
            }
        }
    }
}