using System;
using System.Linq;

namespace CS1IspitUltimate.BiznisSloj
{
    public class Pasus : Tekst
    {
        private string tekst;

        public Pasus(string tekst)
        {
            this.tekst = tekst;
        }

        public override int BrSlova
        {
            get
            {
                int i = 0;
                i = tekst.Count(slovo => !Char.IsWhiteSpace(slovo));
                return i;
            }
        }

        public override int BrReci
        {
            get
            {
                int i = 0, brReci = 0;
                while (i < tekst.Length)
                {
                    while (i < tekst.Length && !char.IsWhiteSpace(tekst[i]))
                        i++;

                    brReci++;

                    while (i < tekst.Length && char.IsWhiteSpace(tekst[i]))
                        i++;
                }
                return brReci;
            }
        }

        public override int BrPasusa { get { return 1; } }

        public override string ToString()
        {
            return tekst + "\r\n";
        }
    }
}
