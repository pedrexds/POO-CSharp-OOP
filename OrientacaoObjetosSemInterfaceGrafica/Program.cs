using System;

namespace POO_CSharp_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            MarcaTexto mt = new MarcaTexto("M8", "Bic", "Amarelo", 10f, 5f, 15f, true, 9.80f, 1, 1);

            mt.info();
        }
    }
}