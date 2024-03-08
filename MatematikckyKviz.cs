using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MathQuizGrafic
{
    public partial class MatematikckyKviz : Form
    {
        public MatematikckyKviz()
        {
            InitializeComponent();
            RundomNumbers rundomNumbers = new RundomNumbers();
            rundomNumbers.VygenerujCislaProScitani();
            labelScitani.Text = rundomNumbers.a + " + " + rundomNumbers.b + " = ";
            rundomNumbers.VygenerujCislaOdecitani();
            labelOdcitani.Text = rundomNumbers.a + " - " + rundomNumbers.b + " = ";
            rundomNumbers.VygenerujCislaNasobeni();
            labelNasobeni.Text = rundomNumbers.a + " * " + rundomNumbers.b + " = ";
            rundomNumbers.VygenerujCislaDeleni();
            labelDeleni.Text = rundomNumbers.a + " / " + rundomNumbers.b + " = ";
            numericUpDownScitaniPomocny.Value = rundomNumbers.vysledekScitani;
            numericUpDownOdcitaniPomocny.Value = rundomNumbers.vysledekOdcitani;
            numericUpDownNasobeniPomocny.Value = rundomNumbers.vysledekNasobeni;
            numericUpDownDeleniPomocny.Value = rundomNumbers.vysledekDeleni;

        }
        RundomNumbers rundomNumbers = new RundomNumbers();
        public int pocetSpravnychVysledku = 0; //Pomocná promìnná pro napoèítávání poètu správných odpovìdí

        public void PorovnaniVysledkuScitani()
        {
            if (numericUpDownScitani.Value == numericUpDownScitaniPomocny.Value)  
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
            if (numericUpDownOdcitani.Value == numericUpDownOdcitaniPomocny.Value)    
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
            if (numericUpDownNasobeni.Value == numericUpDownNasobeniPomocny.Value)   
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
            if (numericUpDownDeleni.Value == numericUpDownDeleniPomocny.Value)    
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