using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    // O ultimo a entrar e o primeiro a sair
    class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(3); // adicionar a pilha
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach(var item in pilha)
            {
                Console.WriteLine($"{item} ");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}");
            // retorna o ultimo objeto da lista e o retorna

            foreach (var item in pilha)
            {
                Console.WriteLine($"{item} ");
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}");
            // retorna o ultimo objeto da pilha mas nao o remove
            Console.WriteLine(pilha.Count);
        }
    }
}
