using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;

            Console.Write("Digite a nota do aluno: ");
            string entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.Write("Possui bom comportamento (S/N)? ");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //{
            //    bomComportamento = true;
            //}

            //bomComportamento = entrada == "S" || entrada == "s" ? true : false;

            bomComportamento = entrada.ToLower() == "s" ? true : false;

            if(nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }
        }
    }
}
