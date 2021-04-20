using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar()
        {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); // inverte o sinal
            Console.WriteLine(!booleano); // inverte o sinal

            numero1++; 
            Console.WriteLine(numero1);

            numero1--;
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2);
            // o numero2 sera decrementado antes de executar a operação
            // e o numero1 sera incrementado depois da operacao
            Console.WriteLine($"{numero1} {numero2}");
        }
    }
}
