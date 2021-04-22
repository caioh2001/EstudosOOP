using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributos
    {
        int a = 10;

        public static void Executar()
        {
            // Acessar a variavel "a" dentro do metodo executar!

            DesafioAtributos variavel = new DesafioAtributos();
            Console.WriteLine(variavel.a);
        }
    }
}
