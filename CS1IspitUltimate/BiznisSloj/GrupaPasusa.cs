using System.Collections.Generic;
using System.Linq;

namespace CS1IspitUltimate.BiznisSloj
{
    public class GrupaPasusa : Tekst
    {
        private readonly List<Pasus> listaPasusa;

        public GrupaPasusa()
        {
            listaPasusa = new List<Pasus>();
        }

        public override int BrSlova
        {
            get
            {
                int i = 0;

                foreach(Pasus pasus in listaPasusa)
                    i += pasus.BrSlova;

                return i;
            }
        }

        public override int BrReci
        {
            get
            {
                int i = 0;

                foreach(Pasus pasus in listaPasusa)
                    i += pasus.BrReci;

                return i;
            }
        }

        public override int BrPasusa
        {
            get
            {
                return listaPasusa.Count();
            }
        }

        public void dodajPasus(Pasus pasus)
        {
            listaPasusa.Add(pasus);
        }

        public override string ToString()
        {
            string tekstIspis = "";

            foreach(Pasus pasus in listaPasusa)
                tekstIspis += pasus;

            return tekstIspis;
        }
    }
}
