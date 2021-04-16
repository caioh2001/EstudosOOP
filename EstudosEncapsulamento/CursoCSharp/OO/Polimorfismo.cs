using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    public class Comida
    {
        public double Peso;

        public Comida(double p)
        {
            Peso = p;
        }

        public Comida()
        {
        }
    }

    public class Feijao : Comida
    {
        public Feijao(double p) : base(p)
        {
        }
    }

    public class Arroz : Comida
    {
        public Arroz(double p) : base(p)
        {
        }
    }

    public class Carne : Comida
    {
        public Carne(double p) : base(p)
        {
        }
    }

    public class Pessoa
    {
        public double Peso;

        public Pessoa(double p)
        {
            Peso = p;
        }

        public void Comer(Comida com)
        {
            Peso += com.Peso;
        }
    }

    class Polimorfismo
    {
        public void Executar()
        {
            Feijao ingrediente1 = new Feijao(3);
            Arroz ingrediente2 = new Arroz(0.25);
            Carne ingrediente3 = new Carne(0.3);

            Pessoa cliente = new Pessoa(80.2);

            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            Console.WriteLine($"Agora o peso do cliente é {cliente.Peso} Kg!");
        }
    }
}
