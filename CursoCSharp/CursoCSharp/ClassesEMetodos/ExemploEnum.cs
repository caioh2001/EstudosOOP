using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };

    public class Filme
    {
        public string Titulo;
        public Genero GeneroFilme;
    }

    class ExemploEnum
    {
        public static void Executar()
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Sharknado 15";
            filmeParaFamilia.GeneroFilme = Genero.Comedia;

            Console.WriteLine($"{filmeParaFamilia.Titulo} e " +
                $"{filmeParaFamilia.GeneroFilme}!");
        } 
    }
}
