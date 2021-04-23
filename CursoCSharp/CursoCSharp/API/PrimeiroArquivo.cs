using System;
using System.Collections.Generic;
using System.Text;
using System.IO; // biblioteca para trabalhar com arquivos

namespace CursoCSharp.API
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = (Environment.OSVersion.Platform
                == PlatformID.Unix) ? Environment.GetEnvironmentVariable
                ("HOME") : Environment.ExpandEnvironmentVariables
                ("%HOMEDRIVE%%HOMEPATH%");

            return path.Replace("~", home);
        }
    }

    class PrimeiroArquivo
    {
        public static void Executar()
        {
            var path = @"~/primeiro_arquivo.txt".ParseHome();
            // ~ signica a pasta Home do usuario

            if(!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse e");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                }
            }

            using(StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("E ");
                sw.WriteLine("possivel ");
                sw.WriteLine("adicionar ");
                sw.WriteLine("mais texto!");
            }
        }
    }
}
