using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes
{
    public class Conta 
    {
        double Saldo;

        public Conta(double saldo)
        {
            Saldo = saldo;
        }

        public void Sacar(double valor)
        {
            if(valor > Saldo)
            {
                throw new ArgumentException("Saldo insuficiente!");
            }

            Saldo -= valor;
        }
    }

    public class PrimeiraExcecao
    {
        public static void Executar()
        {
            var conta = new Conta(1_452.45);

            try
            {
                conta.Sacar(1600);
                Console.WriteLine("Saque feito com sucesso!");
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
