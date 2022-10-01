using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_CSharp_OOP
{
    public interface Funcionalidades
    {
        public bool igual(string modelo);
        public bool compare(Caneta caneta);
        public string getModelo();
        public string getMarca();
        public void info();
        public string toString();
        public float getCapacidadeTotal();
        public bool escrever();
        public void apagar();
    }
}