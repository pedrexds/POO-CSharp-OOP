using System;

namespace POO_CSharp_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            MarcaTexto mt1 = new MarcaTexto("High Text", "Bic", "Amarelo", 100.0f, 5.0f, 8.0f, true, 7.50f, 1, 0);

            mt1.info();
        }
    }
}