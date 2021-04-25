using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>
            {
                new Aluno("Pedro", 24, 8.0),
                new Aluno("Andre", 21, 4.3),
                new Aluno("Ana", 25, 9.5),
                new Aluno("Jorge", 20, 8.5),
                new Aluno("Ana", 21, 7.7),
                new Aluno("Julia", 22, 7.5),
                new Aluno("Marcio", 18, 6.8)
            };

            var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
            Console.WriteLine($"{pedro.Nome} {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals
            ("Fulano"));
            if (fulano == null)
            {
                Console.WriteLine("Aluno inexistente.");
            }

            var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(ana.Nota);

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nome
            .Equals("Sicrano"));
            if (sicrano == null)
            {
                Console.WriteLine("Aluno inexistente.");
            }

            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome
            .Equals("Ana"));
            Console.WriteLine(outraAna.Nota);

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var aluno in exemploSkip)
            {
                Console.WriteLine(aluno.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatorioNotas);

            var mediaDaTurma = alunos.Where(a => a.Nota >= 7)
                .Average(aluno => aluno.Nota);
            Console.WriteLine(mediaDaTurma);
        }
    }
}
