using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            // Conversao implicita
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            // Conversao explicita
            double nota = 9.7;
            int notaTruncada = (int) nota;
            Console.WriteLine($"Nota truncada: {notaTruncada}.");

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine($"Idade inserida: {idadeInteiro}");

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine($"Resultado: {idadeInteiro}");

            Console.Write("Digite o numero: ");
            int.TryParse(Console.ReadLine(), out int numero);
            Console.WriteLine($"Resultado: {numero}");
        }
    }
}
