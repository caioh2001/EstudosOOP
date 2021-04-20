using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            double nota = 6.0;
            double notaDeCorte = 7.0;

            Console.WriteLine($"Nota invalida? {nota < 10.0}");
            Console.WriteLine($"Nota invalida? {nota > 0}");
            Console.WriteLine($"Perfeito? {nota == 10.0}");
            Console.WriteLine($"Tem como melhorar? {nota != 10.0}");
            Console.WriteLine($"Passou por media? {nota >= notaDeCorte}");
            Console.WriteLine($"Recuperacao? {nota < notaDeCorte}");
            Console.WriteLine($"Reprovado? {nota <= 3.0}");
        }
    }
}
