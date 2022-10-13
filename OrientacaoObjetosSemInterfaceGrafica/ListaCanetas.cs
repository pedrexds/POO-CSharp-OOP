using System.Collections;

namespace POO_CSharp_OOP
{
    public class ListaCanetas
    {
        private ArrayList lista;
        
        public ListaCanetas()
        {
            this.lista = new ArrayList();
        }

        public Caneta buscar(string modelo)
        {
            foreach(Caneta can in lista)
            {
                if(can.igual(modelo))
                {
                    return can;
                }
            }
            throw new Exception("Caneta não encontrada");
        }

        public Caneta insereCaneta(Caneta novaCaneta)
        {
            Caneta can = this.buscar(novaCaneta.getModelo());

            if(can != null)
            {
                return can;
            }
            else
            {
                this.lista.Add(novaCaneta);
                return novaCaneta;
            }
        }
    }
}