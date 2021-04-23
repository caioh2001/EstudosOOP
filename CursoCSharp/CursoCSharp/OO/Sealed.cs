using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO
{
    sealed class SemFilho
    {
        public double ValorDaFortuna()
        {
            return 1_407_785.65;
        }
    }

    //class SouFilho : SemFilho
    //{
    //}

    public class Avo
    {
        public virtual bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    public class Pai : Avo
    {
        public sealed override bool HonrarNomeFamilia()
        {
            return true;
        }
    }
    
    public class FilhoRebelde : Pai
    {
        //public override bool HonrarNomeFamilia()
        //{
        //    return false;
        //}
    }

    class Sealed
    {
        public static void Executar()
        {
            SemFilho sem = new SemFilho();
            Console.WriteLine(sem.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}
