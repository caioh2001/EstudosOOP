﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CursoCSharp.API
{
    class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            var dirProjeto = @"D:/Projetos/CursoCSharp/CursoCSharp".ParseHome();

            var dirInfo = new DirectoryInfo(dirProjeto);

            if(!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            Console.WriteLine("=== Arquivos ====");
            var arquivos = dirInfo.GetFiles();

            foreach(var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine("=== Diretorios ===");
            var pastas = dirInfo.GetDirectories();

            foreach(var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent);
        }
    }
}