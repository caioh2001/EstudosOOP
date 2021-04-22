using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    interface Ponto
    {
        void MoverDiagonal(int delta);
    }

    struct Coordenada : Ponto
    {
        public int X;
        public int Y;

        public Coordenada(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void MoverDiagonal(int d)
        {
            X += d;
            Y += d;
        }
    }

    class Struct
    {
        public static void Executar()
        {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.Write("Coordenada inicial: ");
            Console.Write($"X = {coordenadaInicial.X} ");
            Console.WriteLine($"Y = {coordenadaInicial.Y}");

            var coordenadaFinal = new Coordenada(x:9, y:1);
            coordenadaFinal.MoverDiagonal(10);

            Console.Write("Coordenada final: ");
            Console.Write($"X = {coordenadaFinal.X} ");
            Console.WriteLine($"Y = {coordenadaFinal.Y}");
        }
    }
}
