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
        public int pocetSpravnychVysledku = 0; //Pomocn� prom�nn� pro napo��t�v�n� po�tu spr�vn�ch odpov�d�

        public void PorovnaniVysledkuScitani()
        {
            if (numericUpDownScitani.Value == numericUpDownScitaniPomocny.Value)  
            {
                numericUpDownScitani.ForeColor = Color.Blue;      //Pokud se zadan� hodnota rovn� v�sledku operace, tak se zadan� hodnota ozna�� mod�e
                pocetSpravnychVysledku++;                         //Po�et spr�vn�ch odpov�d� se nav��� o 1
            }
            else
            {
                numericUpDownScitani.ForeColor = Color.Red; //V p��pad� chyby se zadan� hodnota ozna�� �erven�
            }
        }

        public void PorovnaniVysledkuOdcitani()
        {
            if (numericUpDownOdcitani.Value == numericUpDownOdcitaniPomocny.Value)    
            {
                numericUpDownOdcitani.ForeColor = Color.Blue;   //Pokud se zadan� hodnota rovn� v�sledku operace, tak se zadan� hodnota ozna�� mod�e.
                pocetSpravnychVysledku++;                       //Po�et spr�vn�ch odpov�d� se nav��� o 1.
            }
            else
            {
                numericUpDownOdcitani.ForeColor = Color.Red; //V p��pad� chyby se zadan� hodnota ozna�� �erven�.
            }
        }

        public void PorovnaniVysledkuNasobeni()
        {
            if (numericUpDownNasobeni.Value == numericUpDownNasobeniPomocny.Value)   
            {
                numericUpDownNasobeni.ForeColor = Color.Blue; //Pokud se zadan� hodnota rovn� v�sledku operace, tak se zadan� hodnota ozna�� mod�e.
                pocetSpravnychVysledku++;                     //Po�et spr�vn�ch odpov�d� se nav��� o 1.
            }
            else
            {
                numericUpDownNasobeni.ForeColor = Color.Red; //V p��pad� chyby se zadan� hodnota ozna�� �erven�.
            }
        }
        public void PorovnaniVysledkuDeleni()
        {
            if (numericUpDownDeleni.Value == numericUpDownDeleniPomocny.Value)    
            {
                numericUpDownDeleni.ForeColor = Color.Blue; //Pokud se zadan� hodnota rovn� v�sledku operace, tak se zadan� hodnota ozna�� mod�e.
                pocetSpravnychVysledku++;                   //Po�et spr�vn�ch odpov�d� se nav��� o 1.
            }
            else
            {
                numericUpDownDeleni.ForeColor = Color.Red; //V p��pad� chyby se zadan� hodnota ozna�� �erven�.
            }
        }

        private void buttonVyhodnoceni_Click(object sender, EventArgs e) //Metoda pro vyhodnocen� kv�zu.
        {
            PorovnaniVysledkuScitani();
            PorovnaniVysledkuOdcitani();
            PorovnaniVysledkuNasobeni();
            PorovnaniVysledkuDeleni();
            MessageBox.Show("Po�et spr�vn�ch odpov�d�: " + pocetSpravnychVysledku);
            Application.Exit();
        }

        int ubehlyCas = 60; //Lze nastavit d�lku hry (po�et sekund), nyn� 60 sekund.
        private void timer1_Tick(object sender, EventArgs e) //Metoda odpo��t�v� �as (60 sekund).
        {
            ubehlyCas--;
            OdpocitavacCasu.Text = $"{ubehlyCas} sekund";
            if (ubehlyCas == 0)
            {
                MessageBox.Show("Do�el ti �as.");
                Application.Exit();
            }

        }
    }
}