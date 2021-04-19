using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual e o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual e a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual e o seu salario? ");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome}, {idade}, R$ {salario}");
        }
    }
}
