using System.Collections.Generic;

namespace CS1IspitUltimate.BiznisSloj
{
    public class Dokument : Tekst
    {
        private readonly List<Tekst> listaTekstualnihDelova;

        public Dokument()
        {
            listaTekstualnihDelova = new List<Tekst>();
        }

        public override int BrSlova
        {
            get
            {
                int i = 0;

                foreach(Tekst tekst in listaTekstualnihDelova)
                    i += tekst.BrSlova;

                return i;
            }
        }

        public override int BrReci
        {
            get
            {
                int i = 0;

                foreach (Tekst tekst in listaTekstualnihDelova)
                    i += tekst.BrReci;

                return i;
            }
        }

        public override int BrPasusa
        {
            get
            {
                int i = 0;

                foreach (Tekst tekst in listaTekstualnihDelova)
                    i += tekst.BrPasusa;

                return i;
            }
        }

        public void dodajTekstualniDeo(Tekst tekstualniDeo)
        {
            listaTekstualnihDelova.Add(tekstualniDeo);
        }

        public override string ToString()
        {
            string tekstIspis = "";

            foreach (Tekst tekst in listaTekstualnihDelova)
                tekstIspis += tekst;

            return tekstIspis;
        }
    }
}
