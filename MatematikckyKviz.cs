using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MathQuizGrafic
{
    public partial class MatematikckyKviz : Form
    {
        MatematickyPriklad scitani;
        MatematickyPriklad odcitani;
        MatematickyPriklad nasobeni;
        MatematickyPriklad deleni;

        public MatematikckyKviz()
        {
            InitializeComponent();
            RundomNumbers rundomNumbers = new RundomNumbers();
            scitani = rundomNumbers.VygenerujCislaProScitani();
            labelScitani.Text = rundomNumbers.a + " + " + rundomNumbers.b + " = ";
            odcitani = rundomNumbers.VygenerujCislaOdecitani();
            labelOdcitani.Text = rundomNumbers.a + " - " + rundomNumbers.b + " = ";
            nasobeni = rundomNumbers.VygenerujCislaNasobeni();
            labelNasobeni.Text = rundomNumbers.a + " * " + rundomNumbers.b + " = ";
            deleni = rundomNumbers.VygenerujCislaDeleni();
            labelDeleni.Text = rundomNumbers.a + " / " + rundomNumbers.b + " = ";


        }
        public int pocetSpravnychVysledku = 0; //Pomocná promìnná pro napoèítávání poètu správných odpovìdí

        public void PorovnaniVysledkuScitani()
        {
            if (numericUpDownScitani.Value == scitani.Vysledek)
            {
                numericUpDownScitani.ForeColor = Color.Blue;      //Pokud se zadaná hodnota rovná výsledku operace, tak se zadaná hodnota oznaèí modøe
                pocetSpravnychVysledku++;                         //Poèet správných odpovìdí se navýší o 1
            }
            else
            {
                numericUpDownScitani.ForeColor = Color.Red; //V pøípadì chyby se zadaná hodnota oznaèí èervenì
            }
        }

        public void PorovnaniVysledkuOdcitani()
        {
            if (numericUpDownOdcitani.Value == odcitani.Vysledek)
            {
                numericUpDownOdcitani.ForeColor = Color.Blue;   //Pokud se zadaná hodnota rovná výsledku operace, tak se zadaná hodnota oznaèí modøe.
                pocetSpravnychVysledku++;                       //Poèet správných odpovìdí se navýší o 1.
            }
            else
            {
                numericUpDownOdcitani.ForeColor = Color.Red; //V pøípadì chyby se zadaná hodnota oznaèí èervenì.
            }
        }

        public void PorovnaniVysledkuNasobeni()
        {
            if (numericUpDownNasobeni.Value == nasobeni.Vysledek)
            {
                numericUpDownNasobeni.ForeColor = Color.Blue; //Pokud se zadaná hodnota rovná výsledku operace, tak se zadaná hodnota oznaèí modøe.
                pocetSpravnychVysledku++;                     //Poèet správných odpovìdí se navýší o 1.
            }
            else
            {
                numericUpDownNasobeni.ForeColor = Color.Red; //V pøípadì chyby se zadaná hodnota oznaèí èervenì.
            }
        }
        public void PorovnaniVysledkuDeleni()
        {
            if (numericUpDownDeleni.Value == deleni.Vysledek)
            {
                numericUpDownDeleni.ForeColor = Color.Blue; //Pokud se zadaná hodnota rovná výsledku operace, tak se zadaná hodnota oznaèí modøe.
                pocetSpravnychVysledku++;                   //Poèet správných odpovìdí se navýší o 1.
            }
            else
            {
                numericUpDownDeleni.ForeColor = Color.Red; //V pøípadì chyby se zadaná hodnota oznaèí èervenì.
            }
        }

        private void buttonVyhodnoceni_Click(object sender, EventArgs e) //Metoda pro vyhodnocení kvízu.
        {
            PorovnaniVysledkuScitani();
            PorovnaniVysledkuOdcitani();
            PorovnaniVysledkuNasobeni();
            PorovnaniVysledkuDeleni();
            timer1.Stop();
            MessageBox.Show("Poèet správných odpovìdí: " + pocetSpravnychVysledku);
            Application.Exit();
        }

        int ubehlyCas = 60; //Lze nastavit délku hry (poèet sekund), nyní 60 sekund.
        private void timer1_Tick(object sender, EventArgs e) //Metoda odpoèítává èas (60 sekund).
        {
            ubehlyCas--;
            OdpocitavacCasu.Text = $"{ubehlyCas} sekund";
            if (ubehlyCas == 0)
            {
                MessageBox.Show("Došel ti èas.");
                Application.Exit();
            }
        }
    }
}