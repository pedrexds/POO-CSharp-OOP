namespace POO_CSharp_OOP
{
    public class Loja
    {
        private ListaCanetas produtos;
        private ListaClientes clientes;

        public Loja()
        {
            this.clientes =  new ListaClientes();
            this.produtos =  new ListaCanetas();
        }
    }
}