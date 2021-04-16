﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    public class DelegateFunAnonima
    {
        delegate string StringOperacao(string s);

        public void Executar()
        {
            StringOperacao inverter = delegate (string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };

            Console.WriteLine(inverter("C# é SHOW !"));
        }
    }
}