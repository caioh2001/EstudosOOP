using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double Desconto = 0.1;

        string nome;

        public string Nome
        {
            get { return "Opcional: " + nome; }
            set { nome = value; }
        }

        // Propriedade autoimplementada
        public double Preco { get; set; }

        // Somente leitura
        public double PrecoComDesconto { get => Preco - (Desconto * Preco); }

        public CarroOpcional()
        {
        }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }

    class Props
    {
        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar Condicionado", 3499.99);

            Console.WriteLine(op1.PrecoComDesconto);
        }
    }
}
