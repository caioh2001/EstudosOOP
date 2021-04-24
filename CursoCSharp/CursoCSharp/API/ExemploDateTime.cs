using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.API
{
    class ExemploDateTime
    {
        public static void Executar()
        {
            var dateTime = new DateTime(year: 2020, month: 2,day: 6);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            // Criar data sem hora 
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            // Criar data com hora
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine($"Hora: {diaAtual.Hour}");
            Console.WriteLine($"Minutos: {diaAtual.Minute}");

            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine(ontem);

            Console.WriteLine(diaAtual.ToString("dd")); // tras apenas o dia 
            Console.WriteLine(diaAtual.ToString("d")); // tras o dia na data 
            Console.WriteLine(diaAtual.ToString("D")); // tras o dia de um modo mais descritivo
            Console.WriteLine(diaAtual.ToString("g")); // tras o dia com a hora
            Console.WriteLine(diaAtual.ToString("G")); // tras o dia com a hora e segundos
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));
            // tras a data e a hora com minuto
        }
    }
}
