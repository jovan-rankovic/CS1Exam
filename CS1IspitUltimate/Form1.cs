using System.Windows.Forms;

using CS1IspitUltimate.BiznisSloj;

namespace CS1IspitUltimate
{
    public partial class Ispit : Form
    {
        public Ispit()
        {
            InitializeComponent();

            Dokument dokument = new Dokument();

            Pasus prviPasus = new Pasus("Prva rečenica.");
            Pasus drugiPasus = new Pasus("Druga rečenica.");

            GrupaPasusa grupaPasusa = new GrupaPasusa();
            Pasus treciPasus = new Pasus("Treća rečenica.");
            Pasus cetvrtiPasus = new Pasus("Četvrta rečenica.");
            grupaPasusa.dodajPasus(treciPasus);
            grupaPasusa.dodajPasus(cetvrtiPasus);

            Pasus petiPasus = new Pasus("Peta rečenica.");

            dokument.dodajTekstualniDeo(prviPasus);
            dokument.dodajTekstualniDeo(drugiPasus);
            dokument.dodajTekstualniDeo(grupaPasusa);
            dokument.dodajTekstualniDeo(petiPasus);

            tbIspis.Text = dokument.ToString();
            tbSlova.Text = dokument.BrSlova.ToString();
            tbReci.Text = dokument.BrReci.ToString();
            tbPasusi.Text = dokument.BrPasusa.ToString();
        }
    }
}
