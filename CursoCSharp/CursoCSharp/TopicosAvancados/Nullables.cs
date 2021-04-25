using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    class Nullables
    {
        static int num3; // variaveis estaticas sao inicializadas por padrao

        public static void Executar()
        {
            Nullable<int> num1 = null;
            int? num2 = null;

            Console.WriteLine(num3);

            if(num1.HasValue)
            {
                Console.WriteLine($"Valor num1: {num1}.");
            }
            else
            {
                Console.WriteLine("A variavel nao possui valor.");
            }

            int valor = num1 ?? 1000; // se a variavel tiver valor
                                      // null vai setar 1000
                                      // se tiver outro valor o mesmo
                                      // e mantido.

            Console.WriteLine(valor);

            bool? booleana = null; // booleana que pode receber null
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine(resultado);

            try
            {
                int x = num1.GetValueOrDefault();
                int y = num2.GetValueOrDefault();
                Console.WriteLine(x + y);
            }
            catch(Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }
    }
}
