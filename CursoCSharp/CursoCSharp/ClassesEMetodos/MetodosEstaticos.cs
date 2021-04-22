using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraEstatica
    {
        // Metodos estaticos nao precisam ser instanciados,
        //eles pertencem a classe e nao a instancia
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Somar(int a, int b)
        {
            return a + b;
        }
    }

    class MetodosEstaticos
    {
        public static void Executar()
        {
            Console.WriteLine($"Resultado multiplicar: {CalculadoraEstatica.Multiplicar(2, 2)}");

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine($"Resultado somar: {calc.Somar(2, 2)}");
        }
    }
}
