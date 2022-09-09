using System;

namespace POO_CSharp_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Caneta unipen = new Caneta("PIN 01-200 Black","Mitsubishi","Preta", 8.0f, 7.0f,12, true);
            Caneta pincel = new Caneta("Pinc Red","Lyke","Vermelha", 15.0f, 15.0f, 11,true);
            Caneta bic = new Caneta("Bic","Bic","4 Cores", 32.0f, 10.0f, 13, false);
            
            unipen.info();
            pincel.info();
            bic.info();
                
            Console.WriteLine("");
            Console.WriteLine(bic.toString());
        }
    }
}