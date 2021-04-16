﻿using System;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;

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

            Console.ReadKey();
        }
    }
}
