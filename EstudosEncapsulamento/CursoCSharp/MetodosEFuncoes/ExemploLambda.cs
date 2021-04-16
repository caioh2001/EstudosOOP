﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public void Executar()
        {
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Lambda com C#!" + a);
            };

            algoNoConsole();

            Func<int> jogarDado = () =>
            {
                Random ran = new Random();
                return ran.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                string.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(1,1,2019));
        }
    }
}
