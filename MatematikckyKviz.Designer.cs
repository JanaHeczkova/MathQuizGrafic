namespace MathQuizGrafic
{
    partial class MatematikckyKviz
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelScitani = new Label();
            numericUpDownScitani = new NumericUpDown();
            labelOdcitani = new Label();
            labelNasobeni = new Label();
            labelDeleni = new Label();
            numericUpDownOdcitani = new NumericUpDown();
            numericUpDownNasobeni = new NumericUpDown();
            numericUpDownDeleni = new NumericUpDown();
            buttonVyhodnoceni = new Button();
            numericUpDownScitaniPomocny = new NumericUpDown();
            numericUpDownOdcitaniPomocny = new NumericUpDown();
            numericUpDownNasobeniPomocny = new NumericUpDown();
            numericUpDownDeleniPomocny = new NumericUpDown();
            timer1 = new System.Windows.Forms.Timer(components);
            OdpocitavacCasu = new Label();
            labelZbyvaCasu = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScitani).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOdcitani).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNasobeni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDeleni).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScitaniPomocny).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOdcitaniPomocny).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNasobeniPomocny).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDeleniPomocny).BeginInit();
            SuspendLayout();
            // 
            // labelScitani
            // 
            labelScitani.AutoSize = true;
            labelScitani.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelScitani.Location = new Point(74, 88);
            labelScitani.Name = "labelScitani";
            labelScitani.Size = new Size(53, 20);
            labelScitani.TabIndex = 0;
            labelScitani.Text = "Sčítání";
            // 
            // numericUpDownScitani
            // 
            numericUpDownScitani.Location = new Point(188, 88);
            numericUpDownScitani.Name = "numericUpDownScitani";
            numericUpDownScitani.Size = new Size(105, 27);
            numericUpDownScitani.TabIndex = 4;
            // 
            // labelOdcitani
            // 
            labelOdcitani.AutoSize = true;
            labelOdcitani.Location = new Point(73, 120);
            labelOdcitani.Name = "labelOdcitani";
            labelOdcitani.Size = new Size(65, 20);
            labelOdcitani.TabIndex = 5;
            labelOdcitani.Text = "Odčítání";
            // 
            // labelNasobeni
            // 
            labelNasobeni.AutoSize = true;
            labelNasobeni.Location = new Point(73, 153);
            labelNasobeni.Name = "labelNasobeni";
            labelNasobeni.Size = new Size(72, 20);
            labelNasobeni.TabIndex = 6;
            labelNasobeni.Text = "Násobení";
            // 
            // labelDeleni
            // 
            labelDeleni.AutoSize = true;
            labelDeleni.Location = new Point(78, 183);
            labelDeleni.Name = "labelDeleni";
            labelDeleni.Size = new Size(52, 20);
            labelDeleni.TabIndex = 7;
            labelDeleni.Text = "Dělení";
            // 
            // numericUpDownOdcitani
            // 
            numericUpDownOdcitani.Location = new Point(189, 118);
            numericUpDownOdcitani.Name = "numericUpDownOdcitani";
            numericUpDownOdcitani.Size = new Size(104, 27);
            numericUpDownOdcitani.TabIndex = 8;
            // 
            // numericUpDownNasobeni
            // 
            numericUpDownNasobeni.Location = new Point(189, 146);
            numericUpDownNasobeni.Name = "numericUpDownNasobeni";
            numericUpDownNasobeni.Size = new Size(104, 27);
            numericUpDownNasobeni.TabIndex = 9;
            // 
            // numericUpDownDeleni
            // 
            numericUpDownDeleni.Location = new Point(189, 176);
            numericUpDownDeleni.Name = "numericUpDownDeleni";
            numericUpDownDeleni.Size = new Size(104, 27);
            numericUpDownDeleni.TabIndex = 10;
            // 
            // buttonVyhodnoceni
            // 
            buttonVyhodnoceni.Location = new Point(134, 230);
            buttonVyhodnoceni.Name = "buttonVyhodnoceni";
            buttonVyhodnoceni.Size = new Size(230, 43);
            buttonVyhodnoceni.TabIndex = 11;
            buttonVyhodnoceni.Text = "Vyhodnotit kvíz";
            buttonVyhodnoceni.UseVisualStyleBackColor = true;
            buttonVyhodnoceni.Click += buttonVyhodnoceni_Click;
            // 
            // numericUpDownScitaniPomocny
            // 
            numericUpDownScitaniPomocny.Location = new Point(474, 84);
            numericUpDownScitaniPomocny.Name = "numericUpDownScitaniPomocny";
            numericUpDownScitaniPomocny.Size = new Size(64, 27);
            numericUpDownScitaniPomocny.TabIndex = 14;
            numericUpDownScitaniPomocny.Visible = false;
            // 
            // numericUpDownOdcitaniPomocny
            // 
            numericUpDownOdcitaniPomocny.Location = new Point(473, 113);
            numericUpDownOdcitaniPomocny.Name = "numericUpDownOdcitaniPomocny";
            numericUpDownOdcitaniPomocny.Size = new Size(65, 27);
            numericUpDownOdcitaniPomocny.TabIndex = 15;
            numericUpDownOdcitaniPomocny.Visible = false;
            // 
            // numericUpDownNasobeniPomocny
            // 
            numericUpDownNasobeniPomocny.Location = new Point(473, 143);
            numericUpDownNasobeniPomocny.Name = "numericUpDownNasobeniPomocny";
            numericUpDownNasobeniPomocny.Size = new Size(65, 27);
            numericUpDownNasobeniPomocny.TabIndex = 16;
            numericUpDownNasobeniPomocny.Visible = false;
            // 
            // numericUpDownDeleniPomocny
            // 
            numericUpDownDeleniPomocny.Location = new Point(473, 176);
            numericUpDownDeleniPomocny.Name = "numericUpDownDeleniPomocny";
            numericUpDownDeleniPomocny.Size = new Size(65, 27);
            numericUpDownDeleniPomocny.TabIndex = 17;
            numericUpDownDeleniPomocny.Visible = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // OdpocitavacCasu
            // 
            OdpocitavacCasu.AutoSize = true;
            OdpocitavacCasu.Location = new Point(387, 34);
            OdpocitavacCasu.Name = "OdpocitavacCasu";
            OdpocitavacCasu.Size = new Size(0, 20);
            OdpocitavacCasu.TabIndex = 18;
            // 
            // labelZbyvaCasu
            // 
            labelZbyvaCasu.AutoSize = true;
            labelZbyvaCasu.Location = new Point(292, 34);
            labelZbyvaCasu.Name = "labelZbyvaCasu";
            labelZbyvaCasu.Size = new Size(89, 20);
            labelZbyvaCasu.TabIndex = 19;
            labelZbyvaCasu.Text = "Zbývá času: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelZbyvaCasu);
            Controls.Add(OdpocitavacCasu);
            Controls.Add(numericUpDownDeleniPomocny);
            Controls.Add(numericUpDownNasobeniPomocny);
            Controls.Add(numericUpDownOdcitaniPomocny);
            Controls.Add(numericUpDownScitaniPomocny);
            Controls.Add(buttonVyhodnoceni);
            Controls.Add(numericUpDownDeleni);
            Controls.Add(numericUpDownNasobeni);
            Controls.Add(numericUpDownOdcitani);
            Controls.Add(labelDeleni);
            Controls.Add(labelNasobeni);
            Controls.Add(labelOdcitani);
            Controls.Add(numericUpDownScitani);
            Controls.Add(labelScitani);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownScitani).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOdcitani).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNasobeni).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDeleni).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScitaniPomocny).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownOdcitaniPomocny).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNasobeniPomocny).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDeleniPomocny).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelScitani;
        private NumericUpDown numericUpDownScitani;
        private Label labelOdcitani;
        private Label labelNasobeni;
        private Label labelDeleni;
        private NumericUpDown numericUpDownOdcitani;
        private NumericUpDown numericUpDownNasobeni;
        private NumericUpDown numericUpDownDeleni;
        private Button buttonVyhodnoceni;
        private NumericUpDown numericUpDownScitaniPomocny;
        private NumericUpDown numericUpDownOdcitaniPomocny;
        private NumericUpDown numericUpDownNasobeniPomocny;
        private NumericUpDown numericUpDownDeleniPomocny;
        private System.Windows.Forms.Timer timer1;
        private Label OdpocitavacCasu;
        private Label labelZbyvaCasu;
    }
}