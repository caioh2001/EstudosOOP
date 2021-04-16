using System;
using CursoCSharp.OO;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Encapsulamentos en = new Encapsulamentos();

            en.Executar();

            Polimorfismo poli = new Polimorfismo();

            poli.Executar();

            Abstract ab = new Abstract();

            ab.Executar();

            Console.ReadKey();
        }
    }
}
