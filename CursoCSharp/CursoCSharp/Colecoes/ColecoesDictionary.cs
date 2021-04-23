using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem Aranha");
            filmes.Add(2004, "Os Incriveis");
            filmes.Add(2006, "O grande truque");
            filmes.Add(2010, "Avatar");

            if (filmes.ContainsKey(2004))
            {
                Console.WriteLine($"2004: " + filmes[2004]);
                Console.WriteLine($"2004: " + filmes.GetValueOrDefault(2008));
            }

            Console.WriteLine(filmes.ContainsValue("O corvo"));

            Console.WriteLine($"Removeu ? {filmes.Remove(2004)}");

            filmes.TryGetValue(2006, out string filme2006);
            Console.WriteLine($"Filme 2006: {filme2006}");

            foreach (var key in filmes.Keys)
            {
                Console.WriteLine(key);
            }

            foreach (var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }

            foreach (KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine($"{filme.Value} e de {filme.Key}");
            }

            foreach (var filme in filmes)
            {
                Console.WriteLine($"{filme.Value} e de {filme.Key}");
            }
        }
    }
}
