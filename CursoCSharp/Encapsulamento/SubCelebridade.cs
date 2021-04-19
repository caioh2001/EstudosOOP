using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        // Todos
        public string InfoPublica = "Tenho um instagram!";

        // Herança
        protected string CorDoOlho = "Verde";

        // Mesmo projeto (assembly)
        internal ulong NumeroCelular = 5531978594526;

        // Herança ou mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas girias!";

        // Mesma classe ou herança no mesmo projeto
        private protected string SegredoFamilia = "BlaBla";

        // private
        private bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }
    }
}
