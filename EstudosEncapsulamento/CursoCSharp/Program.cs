using System;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Encapsulamentos en = new Encapsulamentos();
            en.Executar();

            Polimorfismo poli = new Polimorfismo();
            poli.Executar();

            Abstract ab = new Abstract();
            ab.Executar();

            Interface inter = new Interface();
            inter.Executar();

            Sealed sea = new Sealed();
            sea.Executar();

            ExemploLambda ex = new ExemploLambda();
            ex.Executar();

            LambdasDelegate lamb = new LambdasDelegate();
            lamb.Executar();

            UsandoDelegates use = new UsandoDelegates();
            use.Executar();

            DelegateFunAnonima func = new DelegateFunAnonima();
            func.Executar();

            DelegatesComoParametros del = new DelegatesComoParametros();
            del.Executar();

            MetodosDeExtencao met = new MetodosDeExtencao();
            met.Executar();

            PrimeiraExcecao exc = new PrimeiraExcecao();
            exc.Executar();

            Console.ReadKey();
        }
    }
}
