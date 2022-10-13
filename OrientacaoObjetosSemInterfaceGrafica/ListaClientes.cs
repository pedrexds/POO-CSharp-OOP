using System.Collections;

namespace POO_CSharp_OOP
{
    public class ListaClientes
    {
        private ArrayList lista;

        public ListaClientes()
        {
            this.lista = new ArrayList();
        }
        
        private Cliente buscar(string cpf, string rg) //Sobrecarga de função
        {
            foreach(Cliente cli in this.lista)
            {
                if(cli.igual(cpf, rg))
                {
                    return cli;
                }
            }
            throw new Exception("Cliente não encontrado.");
        }
        
        private Cliente buscar(string cpf) //Sobrecarga de função
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
        
        
        public Cliente insereCliente(string nome, string cpf, string rg, string rua, string estado, int num, string cep)
        {
            Cliente cli = this.buscar(cpf);

            if(cli != null)
            {
                return cli;
            }
            else
            {
                cli = new Cliente(nome, cpf, rg, rua, estado, cep, num);
                this.lista.Add(cli);
                return cli;
            }
        }
    }
}