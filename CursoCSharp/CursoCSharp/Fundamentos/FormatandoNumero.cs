using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;

            // Apenas uma casa decimal
            Console.WriteLine(valor.ToString("F1"));

            // Formato de moeda
            Console.WriteLine(valor.ToString("C"));

            // Formato percentual
            Console.WriteLine(valor.ToString("P"));

            // Duas casas decimais
            Console.WriteLine(valor.ToString("#.##"));

            // Criada uma variavel para salvar o tipo de cultura 
            CultureInfo cultura = new CultureInfo("pt-BR");

            // Formatando para moeda com 2 casas decimais e a cultura salva
            Console.WriteLine(valor.ToString("C2", cultura));

            int inteiro = 256;

            // Completa a variavel ate ela ter 10 casas decimais
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
