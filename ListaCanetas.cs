using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public Caneta insereCaneta(string modelo, string marca, string cor, float capacidadeTotal, float espessura, float comprimento, bool tampa, float valor)
        {
            /*Caneta can = this.buscar(modelo);

            if(can != null)
            {
                return can;
            }
            else
            {
                can = new Caneta(modelo, marca, cor, capacidadeTotal, espessura, comprimento, tampa, valor);
                this.lista.Add(can);
                return can;
            }*/
            throw new NotSupportedException("Operação ainda não implementada");
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